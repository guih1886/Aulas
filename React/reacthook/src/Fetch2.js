import React, { useEffect, useState } from 'react'
import Spinner from 'react-spinners/MoonLoader'

function GetGitUser({ name, location, avatar }) {
    return (
        <div>
            <h1>{name}</h1>
            <p>{location}</p>
            <img src={avatar} alt={name} />
        </div>
    )
}

export default function Fetch2() {
    const [data, setData] = useState(null)
    const [error, setError] = useState(null)
    const [loading, setLoading] = useState(null)
    useEffect(() => {
        setLoading(true)
        fetch((`https://api.github.com/users/guih1886`)).then(resp => resp.json()).then(setData).then(() => setLoading(false)).catch(setError)
    }, [])

    if (loading) return <Spinner />
    if (data) {
        return (
            <GetGitUser name={data.name} location={data.location} avatar={data.avatar_url} />
        )
    } else {
        return <pre>{JSON.stringify(error, null, 2)}</pre>
    }
}
