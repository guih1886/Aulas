import React, { useEffect, useState } from 'react'
import axios from 'axios'

export const DataSource = ({ getData = () => { }, resourceName, children }) => {
    const [state, setState] = useState(null)

    useEffect(() => {
        (async () => {
            const data = await getData()
            setState(data)
        })();
    }, [getData])

    return (
        <>
            {React.Children.map(children, child => {
                if (React.isValidElement(child)) {
                    return React.cloneElement(child, { [resourceName]: state })
                }
                return child
            })}
        </>
    )
}