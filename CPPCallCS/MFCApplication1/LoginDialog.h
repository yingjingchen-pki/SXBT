#pragma once

#ifdef DEBUG
#import "..\SXPWDLib\bin\Debug\SXPWDLib.tlb" no_namespace
#else
#import "..\SXPWDLib\bin\Release\SXPWDLib.tlb" no_namespace
#endif


// CLoginDialog dialog

class CLoginDialog : public CDialogEx
{
	DECLARE_DYNAMIC(CLoginDialog)

public:
	CLoginDialog(CWnd* pParent = NULL);   // standard constructor
	virtual ~CLoginDialog();

// Dialog Data
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_DIALOG1 };
#endif

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	void InitAuthCom();

	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnBnClickedOk();
	CString m_username;
	CString m_password;
};
