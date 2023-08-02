import React, { useContext } from 'react'
import { TreesContext } from './index'


export default function App() {
    const { trees } = useContext(TreesContext)
    console.log(trees)
    return (
        <div>
            <h1>Trees</h1>
            <ul>
                {trees.map((tree) => (
                    <li key={tree.id}>{tree.type}</li>
                ))}
            </ul>
        </div>
    )
}
