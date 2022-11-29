import React, { useState } from 'react'

function useInput(initialValue) {
    const [value, setValue] = useState(initialValue)
    return [
        { value, onChange: (e) => setValue(e.target.value) },
        () => setValue(initialValue)
    ]
}

export default function App() {
    const [titleProps, resetTitle] = useInput("")
    const [colorProps, resetColor] = useInput("")
    const submit = (e) => {
        e.preventDefault()
        alert(`${titleProps.value}, ${colorProps.value}`)
        resetColor()
        resetTitle()
    }
    return (
        <form onSubmit={submit}>
            <input {...titleProps} type="text" placeholder='Insert a color' />
            <input {...colorProps} type="color" />
            <button>Add</button>
        </form>
    )
}
