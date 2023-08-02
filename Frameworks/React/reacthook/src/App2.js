import React, { useEffect, useState } from 'react'

export default function App2() {
    const [data, setData] = useState([])

    useEffect(() => {
        fetch('https://api.github.com/users').then((response) => response.json()).then(setData)
    }, [])

    if (data) {
        return (
            <ul>
                {data.map((user) => (
                    <li key={user.id}>{user.login}</li>
                ))}
                <button onClick={() => setData([])}>Clear data</button>
            </ul>
        )
    }

    return (
        <div>No users</div>
    )
}
