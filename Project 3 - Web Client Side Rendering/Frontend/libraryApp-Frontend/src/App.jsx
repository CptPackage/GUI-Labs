import Navbar from './components/Navbar';
import { AuthProvider, useAuthConfig } from './contexts/auth';
import { MainRouter } from './routes/MainRouter';

function App() {
  const authConfig = useAuthConfig();
  return (
    <div className="App">
      <AuthProvider value={authConfig}>
        <Navbar activeTab={0} />
        <MainRouter />
      </AuthProvider>
    </div>
  )
}

export default App
