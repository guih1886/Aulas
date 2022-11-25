import React, { useEffect, useState } from 'react';
/* import { FaStar } from 'react-icons/fa' */

/* const createArray = (length) => [
  ...Array(length)
];

function Star({ selected = false, onSelect }) {
  return (<FaStar color={selected ? 'yellow' : 'gray'} onClick={onSelect} />)
}

function StarRating({ totalStars = 5 }) {
  const [selectedStars, setSelectedStars] = useState(0);
  return (
    <>
      <p>
        {createArray(totalStars).map((n, i) => {
          return <Star key={i} selected={selectedStars > i} onSelect={() => setSelectedStars(i + 1)} />
        })}
      </p>
      <p>
        Selected stars {selectedStars} of {totalStars}
      </p>
    </>
  )
} */

function App() {
  const [user, setUser] = useState("Jan")
  const [admin, setAdmin] = useState(false)

  useEffect(() => {
    console.log(`Celebrate ${user}`)
  }, [user])

  useEffect(() => {
    console.log(`The user is: ${admin ? "Admin" : "User"}`)
  }, [admin])

  return (
    <section>
      <p>Congratulations {user}!</p>
      <button onClick={() => setUser("Willian")}>Change Winner</button>
      <p>
        {admin ? "logged in" : "not logged in"}
      </p>
      <button onClick={() => setAdmin(true)}>Log in</button>
    </section>
  )
}

export default App;