/********************************************************************************
** Form generated from reading UI file 'bookedit.ui'
**
** Created by: Qt User Interface Compiler version 6.5.0
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_BOOKEDIT_H
#define UI_BOOKEDIT_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QGridLayout>
#include <QtWidgets/QLabel>
#include <QtWidgets/QLineEdit>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_bookEdit
{
public:
    QGridLayout *gridLayout;
    QLabel *label;
    QLabel *authorPlaceholder;
    QLabel *label_3;
    QLabel *titlePlaceholder;
    QLabel *label_4;
    QLabel *datePlaceholder;
    QLabel *label_6;
    QLabel *publisherPlaceholder;
    QLabel *label_5;
    QLabel *bookIdPlaceholder;
    QLabel *label_7;
    QLabel *statusPlaceholder;
    QLabel *label_2;
    QLineEdit *userLineEdit;
    QPushButton *avaliableBtn;
    QPushButton *reservedBtn;
    QPushButton *leasedBtn;
    QPushButton *cancelBtn;

    void setupUi(QWidget *bookEdit)
    {
        if (bookEdit->objectName().isEmpty())
            bookEdit->setObjectName("bookEdit");
        bookEdit->resize(465, 324);
        bookEdit->setMinimumSize(QSize(465, 324));
        gridLayout = new QGridLayout(bookEdit);
        gridLayout->setObjectName("gridLayout");
        label = new QLabel(bookEdit);
        label->setObjectName("label");

        gridLayout->addWidget(label, 0, 0, 1, 1);

        authorPlaceholder = new QLabel(bookEdit);
        authorPlaceholder->setObjectName("authorPlaceholder");

        gridLayout->addWidget(authorPlaceholder, 0, 1, 1, 3);

        label_3 = new QLabel(bookEdit);
        label_3->setObjectName("label_3");

        gridLayout->addWidget(label_3, 1, 0, 1, 1);

        titlePlaceholder = new QLabel(bookEdit);
        titlePlaceholder->setObjectName("titlePlaceholder");

        gridLayout->addWidget(titlePlaceholder, 1, 1, 1, 3);

        label_4 = new QLabel(bookEdit);
        label_4->setObjectName("label_4");

        gridLayout->addWidget(label_4, 2, 0, 1, 1);

        datePlaceholder = new QLabel(bookEdit);
        datePlaceholder->setObjectName("datePlaceholder");

        gridLayout->addWidget(datePlaceholder, 2, 1, 1, 3);

        label_6 = new QLabel(bookEdit);
        label_6->setObjectName("label_6");

        gridLayout->addWidget(label_6, 3, 0, 1, 1);

        publisherPlaceholder = new QLabel(bookEdit);
        publisherPlaceholder->setObjectName("publisherPlaceholder");

        gridLayout->addWidget(publisherPlaceholder, 3, 1, 1, 3);

        label_5 = new QLabel(bookEdit);
        label_5->setObjectName("label_5");

        gridLayout->addWidget(label_5, 4, 0, 1, 1);

        bookIdPlaceholder = new QLabel(bookEdit);
        bookIdPlaceholder->setObjectName("bookIdPlaceholder");

        gridLayout->addWidget(bookIdPlaceholder, 4, 1, 1, 3);

        label_7 = new QLabel(bookEdit);
        label_7->setObjectName("label_7");

        gridLayout->addWidget(label_7, 5, 0, 1, 1);

        statusPlaceholder = new QLabel(bookEdit);
        statusPlaceholder->setObjectName("statusPlaceholder");

        gridLayout->addWidget(statusPlaceholder, 5, 1, 1, 3);

        label_2 = new QLabel(bookEdit);
        label_2->setObjectName("label_2");

        gridLayout->addWidget(label_2, 6, 0, 1, 1);

        userLineEdit = new QLineEdit(bookEdit);
        userLineEdit->setObjectName("userLineEdit");

        gridLayout->addWidget(userLineEdit, 6, 1, 1, 3);

        avaliableBtn = new QPushButton(bookEdit);
        avaliableBtn->setObjectName("avaliableBtn");

        gridLayout->addWidget(avaliableBtn, 7, 0, 1, 1);

        reservedBtn = new QPushButton(bookEdit);
        reservedBtn->setObjectName("reservedBtn");

        gridLayout->addWidget(reservedBtn, 7, 1, 1, 1);

        leasedBtn = new QPushButton(bookEdit);
        leasedBtn->setObjectName("leasedBtn");

        gridLayout->addWidget(leasedBtn, 7, 2, 1, 1);

        cancelBtn = new QPushButton(bookEdit);
        cancelBtn->setObjectName("cancelBtn");

        gridLayout->addWidget(cancelBtn, 7, 3, 1, 1);


        retranslateUi(bookEdit);

        QMetaObject::connectSlotsByName(bookEdit);
    } // setupUi

    void retranslateUi(QWidget *bookEdit)
    {
        bookEdit->setWindowTitle(QCoreApplication::translate("bookEdit", "Form", nullptr));
        label->setText(QCoreApplication::translate("bookEdit", "author:", nullptr));
        authorPlaceholder->setText(QCoreApplication::translate("bookEdit", "author placeholder", nullptr));
        label_3->setText(QCoreApplication::translate("bookEdit", "title:", nullptr));
        titlePlaceholder->setText(QCoreApplication::translate("bookEdit", "title placeolder", nullptr));
        label_4->setText(QCoreApplication::translate("bookEdit", "year published:", nullptr));
        datePlaceholder->setText(QCoreApplication::translate("bookEdit", "date placeholder", nullptr));
        label_6->setText(QCoreApplication::translate("bookEdit", "publisher:", nullptr));
        publisherPlaceholder->setText(QCoreApplication::translate("bookEdit", "publisher placeholder", nullptr));
        label_5->setText(QCoreApplication::translate("bookEdit", "book id:", nullptr));
        bookIdPlaceholder->setText(QCoreApplication::translate("bookEdit", "bookId placeholder", nullptr));
        label_7->setText(QCoreApplication::translate("bookEdit", "status:", nullptr));
        statusPlaceholder->setText(QCoreApplication::translate("bookEdit", "status placceholder", nullptr));
        label_2->setText(QCoreApplication::translate("bookEdit", "User:", nullptr));
        avaliableBtn->setText(QCoreApplication::translate("bookEdit", "avaliable", nullptr));
        reservedBtn->setText(QCoreApplication::translate("bookEdit", "reserved", nullptr));
        leasedBtn->setText(QCoreApplication::translate("bookEdit", "leased", nullptr));
        cancelBtn->setText(QCoreApplication::translate("bookEdit", "cancel", nullptr));
    } // retranslateUi

};

namespace Ui {
    class bookEdit: public Ui_bookEdit {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_BOOKEDIT_H
