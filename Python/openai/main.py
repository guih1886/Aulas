import openai
import os
import dotenv

dotenv.load_dotenv()

openai.api_key = os.getenv("API_KEY")

system = os.getenv('system_config')
user_config = os.getenv('user_config')

resposta = openai.chat.completions.create(
    model="gpt-3.5-turbo",
    messages=[
        {
            "role": "system",
            "content": str(system)
        },
        {
            "role": "user",
            "content": str(user_config)
        }
    ]
)

print(resposta.choices[0].message.content)
teste = input("")
