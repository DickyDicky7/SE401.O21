

class ConnectionPool {
    private static ConnectionPool instance = new ConnectionPool();

    private ConnectionPool() {
        System.out.println("ConnectionPool created");
    }
    public static ConnectionPool getInstance() {
        return instance;
    }

    public void getConnection() {
        System.out.println("Connection acquired");
    }
}

public class Main {
    public static void main(String[] args) {
        System.out.println("Hello world!");

        ConnectionPool.getInstance().getConnection();
    }
}