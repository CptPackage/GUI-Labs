/********************************************************************************
** Form generated from reading UI file 'mainwindow.ui'
**
** Created by: Qt User Interface Compiler version 6.5.0
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_MAINWINDOW_H
#define UI_MAINWINDOW_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QCheckBox>
#include <QtWidgets/QGridLayout>
#include <QtWidgets/QLabel>
#include <QtWidgets/QLineEdit>
#include <QtWidgets/QListWidget>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QMenuBar>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QStatusBar>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_MainWindow
{
public:
    QWidget *centralwidget;
    QGridLayout *gridLayout;
    QListWidget *listWidget;
    QLabel *label_2;
    QPushButton *DeleteAccountBtn;
    QLabel *label_4;
    QLineEdit *titleContains;
    QLabel *label;
    QLabel *instructionLabel;
    QLineEdit *authorContains;
    QCheckBox *myBooksCheckBox;
    QCheckBox *avaliableCheckBox;
    QPushButton *logOutButton;
    QCheckBox *bookingsOnlyCheckBox;
    QCheckBox *rentalsOnlyCheckBox;
    QPushButton *instructionBtn;
    QMenuBar *menubar;
    QStatusBar *statusbar;

    void setupUi(QMainWindow *MainWindow)
    {
        if (MainWindow->objectName().isEmpty())
            MainWindow->setObjectName("MainWindow");
        MainWindow->resize(800, 671);
        MainWindow->setMinimumSize(QSize(800, 600));
        centralwidget = new QWidget(MainWindow);
        centralwidget->setObjectName("centralwidget");
        gridLayout = new QGridLayout(centralwidget);
        gridLayout->setObjectName("gridLayout");
        listWidget = new QListWidget(centralwidget);
        listWidget->setObjectName("listWidget");
        QSizePolicy sizePolicy(QSizePolicy::Expanding, QSizePolicy::Expanding);
        sizePolicy.setHorizontalStretch(100);
        sizePolicy.setVerticalStretch(100);
        sizePolicy.setHeightForWidth(listWidget->sizePolicy().hasHeightForWidth());
        listWidget->setSizePolicy(sizePolicy);
        listWidget->setLayoutDirection(Qt::LeftToRight);
        listWidget->setAlternatingRowColors(true);

        gridLayout->addWidget(listWidget, 4, 0, 1, 8);

        label_2 = new QLabel(centralwidget);
        label_2->setObjectName("label_2");
        label_2->setAlignment(Qt::AlignRight|Qt::AlignTrailing|Qt::AlignVCenter);

        gridLayout->addWidget(label_2, 1, 3, 1, 2);

        DeleteAccountBtn = new QPushButton(centralwidget);
        DeleteAccountBtn->setObjectName("DeleteAccountBtn");

        gridLayout->addWidget(DeleteAccountBtn, 0, 4, 1, 4);

        label_4 = new QLabel(centralwidget);
        label_4->setObjectName("label_4");

        gridLayout->addWidget(label_4, 1, 0, 1, 1);

        titleContains = new QLineEdit(centralwidget);
        titleContains->setObjectName("titleContains");

        gridLayout->addWidget(titleContains, 1, 2, 1, 1);

        label = new QLabel(centralwidget);
        label->setObjectName("label");

        gridLayout->addWidget(label, 1, 1, 1, 1);

        instructionLabel = new QLabel(centralwidget);
        instructionLabel->setObjectName("instructionLabel");
        instructionLabel->setFrameShape(QFrame::Box);

        gridLayout->addWidget(instructionLabel, 3, 0, 1, 8);

        authorContains = new QLineEdit(centralwidget);
        authorContains->setObjectName("authorContains");

        gridLayout->addWidget(authorContains, 1, 5, 1, 1);

        myBooksCheckBox = new QCheckBox(centralwidget);
        myBooksCheckBox->setObjectName("myBooksCheckBox");

        gridLayout->addWidget(myBooksCheckBox, 1, 7, 1, 1);

        avaliableCheckBox = new QCheckBox(centralwidget);
        avaliableCheckBox->setObjectName("avaliableCheckBox");

        gridLayout->addWidget(avaliableCheckBox, 1, 6, 1, 1);

        logOutButton = new QPushButton(centralwidget);
        logOutButton->setObjectName("logOutButton");

        gridLayout->addWidget(logOutButton, 0, 0, 1, 4);

        bookingsOnlyCheckBox = new QCheckBox(centralwidget);
        bookingsOnlyCheckBox->setObjectName("bookingsOnlyCheckBox");

        gridLayout->addWidget(bookingsOnlyCheckBox, 5, 0, 1, 1);

        rentalsOnlyCheckBox = new QCheckBox(centralwidget);
        rentalsOnlyCheckBox->setObjectName("rentalsOnlyCheckBox");

        gridLayout->addWidget(rentalsOnlyCheckBox, 5, 1, 1, 1);

        instructionBtn = new QPushButton(centralwidget);
        instructionBtn->setObjectName("instructionBtn");

        gridLayout->addWidget(instructionBtn, 5, 2, 1, 1);

        MainWindow->setCentralWidget(centralwidget);
        menubar = new QMenuBar(MainWindow);
        menubar->setObjectName("menubar");
        menubar->setGeometry(QRect(0, 0, 800, 21));
        MainWindow->setMenuBar(menubar);
        statusbar = new QStatusBar(MainWindow);
        statusbar->setObjectName("statusbar");
        MainWindow->setStatusBar(statusbar);

        retranslateUi(MainWindow);

        QMetaObject::connectSlotsByName(MainWindow);
    } // setupUi

    void retranslateUi(QMainWindow *MainWindow)
    {
        MainWindow->setWindowTitle(QCoreApplication::translate("MainWindow", "MainWindow", nullptr));
        label_2->setText(QCoreApplication::translate("MainWindow", "search by Author:", nullptr));
        DeleteAccountBtn->setText(QCoreApplication::translate("MainWindow", "Delete account", nullptr));
        label_4->setText(QCoreApplication::translate("MainWindow", "Filters:", nullptr));
        label->setText(QCoreApplication::translate("MainWindow", "search by title:", nullptr));
        instructionLabel->setText(QCoreApplication::translate("MainWindow", "<html><head/><body>To reserve a book double click it.<br/>To unreserve a book also double click it.</body></html>", nullptr));
        myBooksCheckBox->setText(QCoreApplication::translate("MainWindow", "My books", nullptr));
        avaliableCheckBox->setText(QCoreApplication::translate("MainWindow", "Avaliable", nullptr));
        logOutButton->setText(QCoreApplication::translate("MainWindow", "log out", nullptr));
        bookingsOnlyCheckBox->setText(QCoreApplication::translate("MainWindow", "bookings only", nullptr));
        rentalsOnlyCheckBox->setText(QCoreApplication::translate("MainWindow", "rentals only", nullptr));
        instructionBtn->setText(QCoreApplication::translate("MainWindow", "Instructions", nullptr));
    } // retranslateUi

};

namespace Ui {
    class MainWindow: public Ui_MainWindow {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_MAINWINDOW_H
