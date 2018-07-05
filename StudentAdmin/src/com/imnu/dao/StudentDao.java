package com.imnu.dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

import com.imnu.bean.StudentBean;
import com.imnu.util.DBUtil;

public class StudentDao {

	public StudentBean login(StudentBean studentbean) {
		Connection conn = DBUtil.getConnection();
		String sql="select * from student where s_name=? and s_pwd=?";
		PreparedStatement pstm =null;
		ResultSet rs = null ;
		try {
			pstm = conn.prepareStatement(sql);
			pstm.setString(1, studentbean.getS_name());
			pstm.setString(2, studentbean.getS_pwd());
			rs = pstm.executeQuery();
			while(rs.next()) {
				studentbean.setS_no(rs.getString("s_no")); 
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}finally {
			DBUtil.CloseDB(conn,pstm,rs);
		}
		return studentbean;
	}
	

}
