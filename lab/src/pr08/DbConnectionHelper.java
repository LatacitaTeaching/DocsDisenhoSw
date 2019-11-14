package es.unican.istr.sanchezbp.swDesign.pr08.objectPool;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.Properties;
import java.util.TimeZone;

public class DbConnectionHelper {
	
	protected static String username = "polaflixStdUser";
	protected static String password = "thePassword";
	protected static String databaseUrl = "jdbc:mysql://127.0.0.1:3306/polaflix";
	
	public static Connection createConnection() throws SQLException {
		
		Connection result = null;
	
		Properties connectionProps = new Properties();
	    connectionProps.put("user", username);
	    connectionProps.put("password", password);
	    connectionProps.put("serverTimezone","UTC");
	    
	    result = DriverManager.getConnection(databaseUrl, connectionProps);

		return result;
		
		
		
		
	}

}
