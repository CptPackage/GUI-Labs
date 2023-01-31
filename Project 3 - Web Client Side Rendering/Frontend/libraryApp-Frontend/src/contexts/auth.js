import { createContext, useContext, useEffect, useState } from "react";
import { useNavigate } from "react-router";
import Api from "../api";

const defaultAuth = { username: null };

export const AuthContext = createContext(defaultAuth);
AuthContext.displayName = "Authentication Context";
export const AuthProvider = AuthContext.Provider;
export const AuthConsumer = AuthContext.Consumer;

export const useAuthConfig = () => {
    const [authState, setAuthState] = useState(defaultAuth);

    const register = (username, password) => {
        const registered = Api.auth.register(username, password);
        if (registered) {
            setAuthState({ username });
        }
        return registered;
    }

    const login = (username, password) => {
        const logged = Api.auth.login(username, password);
        if (logged) {
            setAuthState({ username });
        }
        return logged;
    }
    const logout = () => { setAuthState(defaultAuth) };

    return {
        authState,
        register,
        login,
        logout
    };
};

export const useAuth = () => {
    return useContext(AuthContext);
}


export const useProtectedRoute = () => {
    const navigate = useNavigate();
    const Auth = useAuth();
    useEffect(() => {
        if (!Auth.authState.username) {
            navigate("/login");
        }
    }, [Auth.authState])
}