import React, { useState, useEffect } from 'react'
import axios from 'axios'
import { useParams, useNavigate } from 'react-router-dom'
import articles from './article-content'
import NotFound from './NotFoundPage';
import CommentsList from '../components/CommentsList';
import AddCommentForm from '../components/AddCommentForm';
import useUser from '../hooks/useUser';

export default function ArticlePage() {
    const [articleInfo, setArticleInfo] = useState({ upvotes: 0, comments: [], canUpvote: false })
    const { canUpvote } = articleInfo
    const { articleId } = useParams();

    const { user, isLoading } = useUser()
    const navigate = useNavigate()

    useEffect(() => {
        const loadArticleInfo = async () => {
            const token = user && await user.getIdToken()
            const headers = token ? { authToken: token } : {}
            const response = await axios.get(`/api/articles/${articleId}`, { headers })
            const newArticleInfo = response.data
            setArticleInfo(newArticleInfo)
        }
        if (!isLoading) {
            loadArticleInfo()
        }
    }, [user, isLoading])

    const article = articles.find(article => article.name === articleId)

    const addUpvote = async () => {
        const token = user && await user.getIdToken()
        const headers = token ? { authToken: token } : {}
        const response = await axios.put(`/api/articles/${articleId}/upvote`, null, { headers })
        const updatedArticle = response.data
        setArticleInfo(updatedArticle)
    }

    if (!article) {
        return <NotFound />
    }

    return (
        <>
            <h1>{article.title}</h1>
            <div className='upvote-section'>
                {user ?
                    <>
                        {canUpvote ? <button onClick={addUpvote}>Upvote</button> : <div>Already upvoted</div>}
                        <p>This article has {articleInfo.upvotes} upvote(s)</p>
                    </>
                    :
                    <button onClick={() => navigate('/login')}>Log in to upvote</button>
                }
            </div>
            {article.content.map((paragraph, i) => (
                <p key={i}>{paragraph}</p>
            ))}
            {user ?
                <>
                    <AddCommentForm articleName={articleId} onArticleUpdated={updatedArticle => setArticleInfo(updatedArticle)} />
                    <CommentsList comments={articleInfo.comments} />
                </>
                :
                <button onClick={() => navigate('/login')}>Log in to comment</button>
            }
        </>
    )
}
