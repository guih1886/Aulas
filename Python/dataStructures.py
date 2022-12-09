# each element is unique, does not repeat
my_set = {1, 2, 3, 4, 4}
print(my_set)

# tuples - does not changes
my_tuple = (1, 2, 3)

# dictionaries, key and values, acess with [], unique keys
my_dictionary = {
    "apple": 'a red fruit'
}
print(my_dictionary['apple'])

a = True
b = False
if a:
    print('a')
    if b:
        print('b')


# function is declared with DEF
def sum(a, b):
    return print(a+b)


sum(3, 5)

#template strings- starts with f (format)
print(f'My favorite number is: {5*2}')
