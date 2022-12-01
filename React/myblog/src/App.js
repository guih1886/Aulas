import './App.css';
import { BrowserRouter, Route, Routes } from 'react-router-dom'
import Home from './pages/HomePage';
import ArticleList from './pages/ArticleListPage';
import ArticlePage from './pages/ArticlePage';
import About from './pages/AboutPage';
import NavBar from './components/NavBar';
import NotFound from './pages/NotFoundPage';

function App() {
  return (
    <BrowserRouter>
      <div className="App">
        <NavBar />
        <div id="page-body">
          <Routes >
            <Route path='/' element={<Home />} />
            <Route path='/about' element={<About />} />
            <Route path='/articles' element={<ArticleList />} />
            <Route path='/articles/:articleId' element={<ArticlePage />} />
            <Route path='*' element={<NotFound />} />
          </Routes>
        </div>
      </div>
    </BrowserRouter>
  );
}
export default App;
