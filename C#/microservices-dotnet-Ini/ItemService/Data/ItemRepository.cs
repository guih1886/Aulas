using System;
using System.Collections.Generic;
using System.Linq;
using ItemService.Dtos;
using ItemService.Models;

namespace ItemService.Data
{
    public class ItemRepository : IItemRepository
    {
        private readonly AppDbContext _context;

        public ItemRepository(AppDbContext context)
        {
            _context = context;
        }

        public void CreateItem(int restauranteId, Item item)
        {
            item.IdRestaurante = restauranteId;
            _context.Itens.Add(item);
        }

        public void CreateRestaurante(Restaurante restaurante)
        {
            _context.Restaurantes.Add(restaurante);
        }

        public bool ExisteRestauranteExterno(int idExternoRestaurante)
        {
            return _context.Restaurantes.Any(restaurante => restaurante.IdExterno == idExternoRestaurante);
        }

        public IEnumerable<Restaurante> GetAllRestaurantes()
        {
            return _context.Restaurantes.ToList();
        }

        public Item GetItem(int restauranteId, int itemId) => _context.Itens
            .Where(item => item.IdRestaurante == restauranteId && item.Id == itemId).FirstOrDefault();

        public IEnumerable<Item> GetItensDeRestaurante(int restauranteId)
        {
            return _context.Itens
                .Where(item => item.IdRestaurante == restauranteId);
        }

        public bool RestauranteExiste(int restauranteId)
        {
            return _context.Restaurantes.Any(restaurante => restaurante.Id == restauranteId);
        }

        public async void SaveChanges()
        {
            await _context.SaveChangesAsync();
        }

        public void SaveRangeAsync(List<Restaurante> lista)
        {
            foreach (var item in lista)
            {
                if (!_context.Restaurantes.Contains(item))
                {
                    _context.Restaurantes.Add(item);
                }
            }

            SaveChanges();
        }
    }
}