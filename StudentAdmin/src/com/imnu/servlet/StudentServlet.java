package com.imnu.servlet;

import java.io.IOException;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

import com.imnu.bean.StudentBean;
import com.imnu.service.StudentService;

/**
 * Servlet implementation class StudentServlet
 */
@WebServlet("/StudentServlet")
public class StudentServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;

	/**
	 * @see HttpServlet#HttpServlet()
	 */
	public StudentServlet() {
		super();
		// TODO Auto-generated constructor stub
	}

	/**
	 * @see HttpServlet#doGet(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void doGet(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		doPost(request, response);
	}

	/**
	 * @see HttpServlet#doPost(HttpServletRequest request, HttpServletResponse
	 *      response)
	 */
	protected void doPost(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		// TODO Auto-generated method stub

		// TODO Auto-generated method stub
		// 1.接收请求参数
		String username = request.getParameter("username");
		String pwd = request.getParameter("pwd");
		// 2.将数据提交服务层
		StudentService student_service = new StudentService();
		StudentBean user = student_service.LoginValidate(username, pwd);
		// 3.页面跳转
		if (user != null) {
			request.setAttribute("user", user);
			request.getRequestDispatcher("success.jsp").forward(request, response);
		} else {
			response.sendRedirect("login.jsp");
		}
	}

}
