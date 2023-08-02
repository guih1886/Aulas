import './App.css';
import { BrowserRouter, Route, Routes } from 'react-router-dom'
import Home from './pages/HomePage';
import ArticleList from './pages/ArticleListPage';
import ArticlePage from './pages/ArticlePage';
import About from './pages/AboutPage';
import NavBar from './components/NavBar';
import NotFound from './pages/NotFoundPage';
import LoginPage from './pages/LoginPage'
import CreateAccountPage from './pages/CreateAccountPage'
import useUser from './hooks/useUser';

function App() {
  const { user, isLoading } = useUser()
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
            <Route path='/login' element={<LoginPage />} />
            <Route path='/create-account' element={<CreateAccountPage />} />
            <Route path='*' element={<NotFound />} />
          </Routes>
        </div>
      </div>
    </BrowserRouter>
  );
}
export default App;
