import Layout from "../components/Layout";

export default function Jsx() {
    //fora do return está i JS puro, dentro está o conceito de react. Para acessar é usado chaves

    return (
        <div>
            <Layout>
                <h1>JSX é um conceito Central.</h1>
                <h2>{"Muito legal!!!".toLocaleUpperCase()}</h2>
            </Layout>
        </div>
    )
}