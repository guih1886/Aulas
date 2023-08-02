import React from "react"
import './estilos.css'

export const Card: React.FC = ({ children }) => {
    return (
        <div className="card">
            {children}
        </div>
    )
}