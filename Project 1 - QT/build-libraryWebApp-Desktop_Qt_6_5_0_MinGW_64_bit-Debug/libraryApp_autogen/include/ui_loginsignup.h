/********************************************************************************
** Form generated from reading UI file 'loginsignup.ui'
**
** Created by: Qt User Interface Compiler version 6.5.0
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_LOGINSIGNUP_H
#define UI_LOGINSIGNUP_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QHBoxLayout>
#include <QtWidgets/QLabel>
#include <QtWidgets/QLineEdit>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QMenuBar>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QSpacerItem>
#include <QtWidgets/QStatusBar>
#include <QtWidgets/QVBoxLayout>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_loginSignup
{
public:
    QWidget *centralwidget;
    QVBoxLayout *verticalLayout_3;
    QSpacerItem *verticalSpacer_10;
    QHBoxLayout *horizontalLayout;
    QVBoxLayout *verticalLayout_2;
    QSpacerItem *verticalSpacer_3;
    QLabel *label;
    QSpacerItem *verticalSpacer_4;
    QLineEdit *login;
    QSpacerItem *verticalSpacer;
    QLineEdit *password;
    QSpacerItem *verticalSpacer_2;
    QPushButton *login_button;
    QVBoxLayout *verticalLayout;
    QSpacerItem *verticalSpacer_9;
    QLabel *label_2;
    QSpacerItem *verticalSpacer_5;
    QLineEdit *r_login;
    QSpacerItem *verticalSpacer_6;
    QLineEdit *r_password1;
    QSpacerItem *verticalSpacer_7;
    QLineEdit *r_password2;
    QSpacerItem *verticalSpacer_8;
    QPushButton *signUp_button;
    QSpacerItem *verticalSpacer_11;
    QMenuBar *menubar;
    QStatusBar *statusbar;

    void setupUi(QMainWindow *loginSignup)
    {
        if (loginSignup->objectName().isEmpty())
            loginSignup->setObjectName("loginSignup");
        loginSignup->resize(800, 600);
        loginSignup->setMinimumSize(QSize(800, 600));
        centralwidget = new QWidget(loginSignup);
        centralwidget->setObjectName("centralwidget");
        verticalLayout_3 = new QVBoxLayout(centralwidget);
        verticalLayout_3->setObjectName("verticalLayout_3");
        verticalSpacer_10 = new QSpacerItem(20, 73, QSizePolicy::Minimum, QSizePolicy::Expanding);

        verticalLayout_3->addItem(verticalSpacer_10);

        horizontalLayout = new QHBoxLayout();
        horizontalLayout->setObjectName("horizontalLayout");
        verticalLayout_2 = new QVBoxLayout();
        verticalLayout_2->setObjectName("verticalLayout_2");
        verticalSpacer_3 = new QSpacerItem(20, 40, QSizePolicy::Minimum, QSizePolicy::Expanding);

        verticalLayout_2->addItem(verticalSpacer_3);

        label = new QLabel(centralwidget);
        label->setObjectName("label");
        label->setAlignment(Qt::AlignCenter);

        verticalLayout_2->addWidget(label);

        verticalSpacer_4 = new QSpacerItem(20, 40, QSizePolicy::Minimum, QSizePolicy::Expanding);

        verticalLayout_2->addItem(verticalSpacer_4);

        login = new QLineEdit(centralwidget);
        login->setObjectName("login");

        verticalLayout_2->addWidget(login);

        verticalSpacer = new QSpacerItem(20, 40, QSizePolicy::Minimum, QSizePolicy::Expanding);

        verticalLayout_2->addItem(verticalSpacer);

        password = new QLineEdit(centralwidget);
        password->setObjectName("password");
        password->setEchoMode(QLineEdit::Password);

        verticalLayout_2->addWidget(password);

        verticalSpacer_2 = new QSpacerItem(20, 40, QSizePolicy::Minimum, QSizePolicy::Expanding);

        verticalLayout_2->addItem(verticalSpacer_2);

        login_button = new QPushButton(centralwidget);
        login_button->setObjectName("login_button");
        login_button->setEnabled(true);

        verticalLayout_2->addWidget(login_button);


        horizontalLayout->addLayout(verticalLayout_2);

        verticalLayout = new QVBoxLayout();
        verticalLayout->setObjectName("verticalLayout");
        verticalSpacer_9 = new QSpacerItem(20, 40, QSizePolicy::Minimum, QSizePolicy::Expanding);

        verticalLayout->addItem(verticalSpacer_9);

        label_2 = new QLabel(centralwidget);
        label_2->setObjectName("label_2");
        label_2->setAlignment(Qt::AlignCenter);

        verticalLayout->addWidget(label_2);

        verticalSpacer_5 = new QSpacerItem(20, 40, QSizePolicy::Minimum, QSizePolicy::Expanding);

        verticalLayout->addItem(verticalSpacer_5);

        r_login = new QLineEdit(centralwidget);
        r_login->setObjectName("r_login");

        verticalLayout->addWidget(r_login);

        verticalSpacer_6 = new QSpacerItem(20, 40, QSizePolicy::Minimum, QSizePolicy::Expanding);

        verticalLayout->addItem(verticalSpacer_6);

        r_password1 = new QLineEdit(centralwidget);
        r_password1->setObjectName("r_password1");
        r_password1->setEchoMode(QLineEdit::Password);

        verticalLayout->addWidget(r_password1);

        verticalSpacer_7 = new QSpacerItem(20, 40, QSizePolicy::Minimum, QSizePolicy::Expanding);

        verticalLayout->addItem(verticalSpacer_7);

        r_password2 = new QLineEdit(centralwidget);
        r_password2->setObjectName("r_password2");
        r_password2->setEchoMode(QLineEdit::Password);

        verticalLayout->addWidget(r_password2);

        verticalSpacer_8 = new QSpacerItem(20, 40, QSizePolicy::Minimum, QSizePolicy::Expanding);

        verticalLayout->addItem(verticalSpacer_8);

        signUp_button = new QPushButton(centralwidget);
        signUp_button->setObjectName("signUp_button");
        signUp_button->setEnabled(true);

        verticalLayout->addWidget(signUp_button);


        horizontalLayout->addLayout(verticalLayout);


        verticalLayout_3->addLayout(horizontalLayout);

        verticalSpacer_11 = new QSpacerItem(20, 72, QSizePolicy::Minimum, QSizePolicy::Expanding);

        verticalLayout_3->addItem(verticalSpacer_11);

        loginSignup->setCentralWidget(centralwidget);
        menubar = new QMenuBar(loginSignup);
        menubar->setObjectName("menubar");
        menubar->setGeometry(QRect(0, 0, 800, 21));
        loginSignup->setMenuBar(menubar);
        statusbar = new QStatusBar(loginSignup);
        statusbar->setObjectName("statusbar");
        loginSignup->setStatusBar(statusbar);

        retranslateUi(loginSignup);

        QMetaObject::connectSlotsByName(loginSignup);
    } // setupUi

    void retranslateUi(QMainWindow *loginSignup)
    {
        loginSignup->setWindowTitle(QCoreApplication::translate("loginSignup", "loginSignup", nullptr));
        label->setText(QCoreApplication::translate("loginSignup", "Log in test", nullptr));
        login->setPlaceholderText(QCoreApplication::translate("loginSignup", "login", nullptr));
        password->setPlaceholderText(QCoreApplication::translate("loginSignup", "password", nullptr));
        login_button->setText(QCoreApplication::translate("loginSignup", "Log in", nullptr));
        label_2->setText(QCoreApplication::translate("loginSignup", "Sing Up", nullptr));
        r_login->setPlaceholderText(QCoreApplication::translate("loginSignup", "set login", nullptr));
        r_password1->setPlaceholderText(QCoreApplication::translate("loginSignup", "password", nullptr));
        r_password2->setPlaceholderText(QCoreApplication::translate("loginSignup", "repeat password", nullptr));
        signUp_button->setText(QCoreApplication::translate("loginSignup", "Sign up", nullptr));
    } // retranslateUi

};

namespace Ui {
    class loginSignup: public Ui_loginSignup {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_LOGINSIGNUP_H
