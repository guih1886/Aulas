import React from 'react'
import { useFetch } from './useFetch'

function Fetch({ login }) {
    const { loading, data, error } = useFetch(`https://api.github.com/users/${login}`)
    if (loading) return <h1>Loading...</h1>
    if (error) {
        return (
            <pre>{JSON.stringify(error, null, 2)}</pre>
        )
    } else {
        return (
            <pre>{JSON.stringify(data, null, 2)}</pre>
        )
    }
}

export default function App() {
    return (
        <Fetch login='guih1886' />
    )
}