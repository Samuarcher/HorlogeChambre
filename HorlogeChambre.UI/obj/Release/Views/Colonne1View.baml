   M S B A M L   `   `   `  ���� L  HHorlogeChambre.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:Samuarcher.HorlogeChambre.UI.ViewModels'Samuarcher.HorlogeChambre.UI.ViewModels  5    /Samuarcher.HorlogeChambre.UI.Views.Colonne1View   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     L
viewModels5clr-namespace:Samuarcher.HorlogeChambre.UI.ViewModels     .����   �� Orientation$  Vertical=�$
��1150��.+��� $��Heure��.���� $	��200(����� *
DateJour+ �� ConverterCulture$ fr-FR�� �� StringFormat$ {0:T}���� $
��Date��.���� .+��� $	��150(����� *
DateJour+$ fr-FR��$ {0:dddd}���� $	��150(����� *
DateJour+$ fr-FR��$ {0:dd MMM yyyy}���� $��Soleil��.���� $  Vertical=�.+��� $��50(�$
��Left=����� *LeverSoleil+$ fr-FR��$$ Heure léver du soleil - {0:t}���� $��50(�$
��Left=����� *CoucherSoleil+$ fr-FR��$% Heure coucher du soleil - {0:t}���� $��
Trajet taf��.���� $  Vertical=�.+��� $��50(�$
��Left=���`� $ {0} : {1} min��.1���  �� Path$ LibelleTrajet1��� $ DureeTrajet1��� $��50(�$
��Left=���`� $ {0} : {1} min��.1��� $ LibelleTrajet2��� $ DureeTrajet2��� $��50(�$
��Left=���`� $ {0} : {1} min��.1��� $ LibelleTrajet3��� $ DureeTrajet3�