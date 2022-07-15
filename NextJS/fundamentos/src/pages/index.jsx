import Link from "next/link"

export default function Home() {
  return (
    <div>
      <h1>Capítulo Next & React!</h1>
      <Link href={"/main"}>Próxima página</Link>
    </div>
  )
}
