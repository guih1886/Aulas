import React from 'react';
import ReactDOM from 'react-dom/client';
import App from './App';
import { initializeApp } from "firebase/app";

const firebaseConfig = {
  apiKey: "AIzaSyA7i5CcnjA5REI9cjHaBgBk6on35dp7UYo",
  authDomain: "my-react-blog-d89fc.firebaseapp.com",
  projectId: "my-react-blog-d89fc",
  storageBucket: "my-react-blog-d89fc.appspot.com",
  messagingSenderId: "431366255131",
  appId: "1:431366255131:web:12c30f78774ab65333bebe"
};
const app = initializeApp(firebaseConfig);


const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <React.StrictMode>
    <App />
  </React.StrictMode>
);

