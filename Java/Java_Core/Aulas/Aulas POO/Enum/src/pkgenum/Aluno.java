package pkgenum;

public class Aluno {

    private float nota1;
    private float nota2;
    private float nota3;
    Status status;

    public enum Status {
        Aprovado,
        Reprovado
    }

    public Aluno(float nota1, float nota2, float nota3) {
        this.nota1 = nota1;
        this.nota2 = nota2;
        this.nota3 = nota3;
    }

    public void retornaValor() {
        float result = (this.nota1 + this.nota2 + this.nota3) / 3;
        if (result > 6) {
            System.out.println(Status.Aprovado);
        } else {
            System.out.println(Status.Reprovado);
        }
    }

    public float getNota1() {
        return nota1;
    }

    public void setNota1(float nota1) {
        this.nota1 = nota1;
    }

    public float getNota2() {
        return nota2;
    }

    public void setNota2(float nota2) {
        this.nota2 = nota2;
    }

    public float getNota3() {
        return nota3;
    }

    public void setNota3(float nota3) {
        this.nota3 = nota3;
    }

    public Status getStatus() {
        return status;
    }

    public void setStatus(Status status) {
        this.status = status;
    }

}
