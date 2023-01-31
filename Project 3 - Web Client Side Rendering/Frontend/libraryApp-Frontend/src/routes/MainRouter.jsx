import { Route, Routes } from "react-router-dom";
import Books from "../pages/Books";
import Home from "../pages/Home";
import Login from "../pages/Login";
import Register from "../pages/Register";
import Reservations from "../pages/Reservations";
import Users from "../pages/Users";


export const MainRouter = () => (    
        <Routes>
            <Route path="/" element={<Home />} />
            <Route path="/login" element={<Login />} />
            <Route path="/signup" element={<Register />} />
            <Route path="/books" element={<Books />} />
            <Route path="/reservations" element={<Reservations />} />
            <Route path="/users" element={<Users />} />
        </Routes>
);