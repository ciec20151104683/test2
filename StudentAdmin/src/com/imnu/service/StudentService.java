package com.imnu.service;

import com.imnu.bean.StudentBean;
import com.imnu.dao.StudentDao;


public class StudentService {

	public StudentBean LoginValidate(String username, String pwd) {
		StudentBean studentbean = new StudentBean();
		studentbean.setS_name(username);
		studentbean.setS_pwd(pwd);
		StudentDao sd = new StudentDao();
		StudentBean rs = sd.login(studentbean);
		return rs;
	}

}
