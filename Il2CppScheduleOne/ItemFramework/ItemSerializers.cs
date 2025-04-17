using System;
using Il2CppFishNet.Serializing;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using Il2CppScheduleOne.ObjectScripts.WateringCan;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Storage;
using Il2CppSystem;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005E9 RID: 1513
	public static class ItemSerializers : Object
	{
		// Token: 0x06008407 RID: 33799 RVA: 0x00230CCC File Offset: 0x0022EECC
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSerializers()
		{
			Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemSerializers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr);
			ItemSerializers.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, "DEBUG");
			ItemSerializers.NativeMethodInfoPtr_Read_Private_Static_ItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679802);
			ItemSerializers.NativeMethodInfoPtr_WriteItemInstance_Public_Static_Void_Writer_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679803);
			ItemSerializers.NativeMethodInfoPtr_ReadItemInstance_Public_Static_ItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679804);
			ItemSerializers.NativeMethodInfoPtr_DirectReadItemInstance_Private_Static_ItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679805);
			ItemSerializers.NativeMethodInfoPtr_WriteStorableItemInstance_Public_Static_Void_Writer_StorableItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679806);
			ItemSerializers.NativeMethodInfoPtr_ReadStorableItemInstance_Public_Static_StorableItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679807);
			ItemSerializers.NativeMethodInfoPtr_DirectReadStorableItemInstance_Private_Static_StorableItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679808);
			ItemSerializers.NativeMethodInfoPtr_WriteCashInstance_Public_Static_Void_Writer_CashInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679809);
			ItemSerializers.NativeMethodInfoPtr_ReadCashInstance_Public_Static_CashInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679810);
			ItemSerializers.NativeMethodInfoPtr_DirectReadCashInstance_Private_Static_CashInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679811);
			ItemSerializers.NativeMethodInfoPtr_WriteQualityItemInstance_Public_Static_Void_Writer_QualityItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679812);
			ItemSerializers.NativeMethodInfoPtr_ReadQualityItemInstance_Public_Static_QualityItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679813);
			ItemSerializers.NativeMethodInfoPtr_DirectReadQualityItemInstance_Private_Static_QualityItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679814);
			ItemSerializers.NativeMethodInfoPtr_WriteClothingInstance_Public_Static_Void_Writer_ClothingInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679815);
			ItemSerializers.NativeMethodInfoPtr_ReadClothingInstance_Public_Static_ClothingInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679816);
			ItemSerializers.NativeMethodInfoPtr_DirectReadClothingInstance_Private_Static_ClothingInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679817);
			ItemSerializers.NativeMethodInfoPtr_WriteProductItemInstance_Public_Static_Void_Writer_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679818);
			ItemSerializers.NativeMethodInfoPtr_ReadProductItemInstance_Public_Static_ProductItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679819);
			ItemSerializers.NativeMethodInfoPtr_DirectReadProductItemInstance_Private_Static_ProductItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679820);
			ItemSerializers.NativeMethodInfoPtr_WriteWeedInstance_Public_Static_Void_Writer_WeedInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679821);
			ItemSerializers.NativeMethodInfoPtr_ReadWeedInstance_Public_Static_WeedInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679822);
			ItemSerializers.NativeMethodInfoPtr_DirectReadWeedInstance_Private_Static_WeedInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679823);
			ItemSerializers.NativeMethodInfoPtr_WriteMethInstance_Public_Static_Void_Writer_MethInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679824);
			ItemSerializers.NativeMethodInfoPtr_ReadMethInstance_Public_Static_MethInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679825);
			ItemSerializers.NativeMethodInfoPtr_DirectReadMethInstance_Private_Static_MethInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679826);
			ItemSerializers.NativeMethodInfoPtr_WriteCocaineInstance_Public_Static_Void_Writer_CocaineInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679827);
			ItemSerializers.NativeMethodInfoPtr_ReadCocaineInstance_Public_Static_CocaineInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679828);
			ItemSerializers.NativeMethodInfoPtr_DirectReadCocaineInstance_Private_Static_CocaineInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679829);
			ItemSerializers.NativeMethodInfoPtr_WriteIntegerItemInstance_Public_Static_Void_Writer_IntegerItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679830);
			ItemSerializers.NativeMethodInfoPtr_ReadIntegerItemInstance_Public_Static_IntegerItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679831);
			ItemSerializers.NativeMethodInfoPtr_DirectReadIntegerItemInstance_Private_Static_IntegerItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679832);
			ItemSerializers.NativeMethodInfoPtr_WriteWateringCanInstance_Public_Static_Void_Writer_WateringCanInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679833);
			ItemSerializers.NativeMethodInfoPtr_ReadWateringCanInstance_Public_Static_WateringCanInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679834);
			ItemSerializers.NativeMethodInfoPtr_DirectReadWateringCanInstance_Private_Static_WateringCanInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679835);
			ItemSerializers.NativeMethodInfoPtr_WriteTrashGrabberInstance_Public_Static_Void_Writer_TrashGrabberInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679836);
			ItemSerializers.NativeMethodInfoPtr_ReadTrashGrabberInstance_Public_Static_TrashGrabberInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679837);
			ItemSerializers.NativeMethodInfoPtr_DirectReadTrashGrabberInstance_Private_Static_TrashGrabberInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100679838);
		}

		// Token: 0x06008408 RID: 33800 RVA: 0x00230FF4 File Offset: 0x0022F1F4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 247790, RefRangeEnd = 247802, XrefRangeStart = 247702, XrefRangeEnd = 247790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ItemInstance Read(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_Read_Private_Static_ItemInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06008409 RID: 33801 RVA: 0x00231038 File Offset: 0x0022F238
		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 247824, RefRangeEnd = 247906, XrefRangeStart = 247802, XrefRangeEnd = 247824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteItemInstance(this Writer writer, ItemInstance value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteItemInstance_Public_Static_Void_Writer_ItemInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600840A RID: 33802 RVA: 0x00231080 File Offset: 0x0022F280
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 247907, RefRangeEnd = 247956, XrefRangeStart = 247906, XrefRangeEnd = 247907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ItemInstance ReadItemInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadItemInstance_Public_Static_ItemInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600840B RID: 33803 RVA: 0x002310C4 File Offset: 0x0022F2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247956, XrefRangeEnd = 247960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ItemInstance DirectReadItemInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadItemInstance_Private_Static_ItemInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600840C RID: 33804 RVA: 0x00231108 File Offset: 0x0022F308
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 247984, RefRangeEnd = 247990, XrefRangeStart = 247960, XrefRangeEnd = 247984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteStorableItemInstance(this Writer writer, StorableItemInstance value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteStorableItemInstance_Public_Static_Void_Writer_StorableItemInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600840D RID: 33805 RVA: 0x00231150 File Offset: 0x0022F350
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 247992, RefRangeEnd = 247995, XrefRangeStart = 247990, XrefRangeEnd = 247992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StorableItemInstance ReadStorableItemInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadStorableItemInstance_Public_Static_StorableItemInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorableItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600840E RID: 33806 RVA: 0x00231194 File Offset: 0x0022F394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 247995, XrefRangeEnd = 248004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StorableItemInstance DirectReadStorableItemInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadStorableItemInstance_Private_Static_StorableItemInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorableItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600840F RID: 33807 RVA: 0x002311D8 File Offset: 0x0022F3D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248004, XrefRangeEnd = 248014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteCashInstance(this Writer writer, CashInstance value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteCashInstance_Public_Static_Void_Writer_CashInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008410 RID: 33808 RVA: 0x00231220 File Offset: 0x0022F420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248014, XrefRangeEnd = 248016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CashInstance ReadCashInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadCashInstance_Public_Static_CashInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr3) : null;
		}

		// Token: 0x06008411 RID: 33809 RVA: 0x00231264 File Offset: 0x0022F464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248016, XrefRangeEnd = 248027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CashInstance DirectReadCashInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadCashInstance_Private_Static_CashInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr3) : null;
		}

		// Token: 0x06008412 RID: 33810 RVA: 0x002312A8 File Offset: 0x0022F4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248027, XrefRangeEnd = 248033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteQualityItemInstance(this Writer writer, QualityItemInstance value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteQualityItemInstance_Public_Static_Void_Writer_QualityItemInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008413 RID: 33811 RVA: 0x002312F0 File Offset: 0x0022F4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248033, XrefRangeEnd = 248035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static QualityItemInstance ReadQualityItemInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadQualityItemInstance_Public_Static_QualityItemInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<QualityItemInstance>(intPtr3) : null;
		}

		// Token: 0x06008414 RID: 33812 RVA: 0x00231334 File Offset: 0x0022F534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248035, XrefRangeEnd = 248044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static QualityItemInstance DirectReadQualityItemInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadQualityItemInstance_Private_Static_QualityItemInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<QualityItemInstance>(intPtr3) : null;
		}

		// Token: 0x06008415 RID: 33813 RVA: 0x00231378 File Offset: 0x0022F578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248044, XrefRangeEnd = 248054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteClothingInstance(this Writer writer, ClothingInstance value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteClothingInstance_Public_Static_Void_Writer_ClothingInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008416 RID: 33814 RVA: 0x002313C0 File Offset: 0x0022F5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248054, XrefRangeEnd = 248056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ClothingInstance ReadClothingInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadClothingInstance_Public_Static_ClothingInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClothingInstance>(intPtr3) : null;
		}

		// Token: 0x06008417 RID: 33815 RVA: 0x00231404 File Offset: 0x0022F604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248056, XrefRangeEnd = 248065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ClothingInstance DirectReadClothingInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadClothingInstance_Private_Static_ClothingInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClothingInstance>(intPtr3) : null;
		}

		// Token: 0x06008418 RID: 33816 RVA: 0x00231448 File Offset: 0x0022F648
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 248095, RefRangeEnd = 248111, XrefRangeStart = 248065, XrefRangeEnd = 248095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteProductItemInstance(this Writer writer, ProductItemInstance value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteProductItemInstance_Public_Static_Void_Writer_ProductItemInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008419 RID: 33817 RVA: 0x00231490 File Offset: 0x0022F690
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 248113, RefRangeEnd = 248118, XrefRangeStart = 248111, XrefRangeEnd = 248113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProductItemInstance ReadProductItemInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadProductItemInstance_Public_Static_ProductItemInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600841A RID: 33818 RVA: 0x002314D4 File Offset: 0x0022F6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248118, XrefRangeEnd = 248129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProductItemInstance DirectReadProductItemInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadProductItemInstance_Private_Static_ProductItemInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600841B RID: 33819 RVA: 0x00231518 File Offset: 0x0022F718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248129, XrefRangeEnd = 248140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteWeedInstance(this Writer writer, WeedInstance value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteWeedInstance_Public_Static_Void_Writer_WeedInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600841C RID: 33820 RVA: 0x00231560 File Offset: 0x0022F760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248140, XrefRangeEnd = 248142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WeedInstance ReadWeedInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadWeedInstance_Public_Static_WeedInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WeedInstance>(intPtr3) : null;
		}

		// Token: 0x0600841D RID: 33821 RVA: 0x002315A4 File Offset: 0x0022F7A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248142, XrefRangeEnd = 248153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WeedInstance DirectReadWeedInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadWeedInstance_Private_Static_WeedInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WeedInstance>(intPtr3) : null;
		}

		// Token: 0x0600841E RID: 33822 RVA: 0x002315E8 File Offset: 0x0022F7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248153, XrefRangeEnd = 248164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteMethInstance(this Writer writer, MethInstance value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteMethInstance_Public_Static_Void_Writer_MethInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600841F RID: 33823 RVA: 0x00231630 File Offset: 0x0022F830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248164, XrefRangeEnd = 248166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethInstance ReadMethInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadMethInstance_Public_Static_MethInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethInstance>(intPtr3) : null;
		}

		// Token: 0x06008420 RID: 33824 RVA: 0x00231674 File Offset: 0x0022F874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248166, XrefRangeEnd = 248177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethInstance DirectReadMethInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadMethInstance_Private_Static_MethInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethInstance>(intPtr3) : null;
		}

		// Token: 0x06008421 RID: 33825 RVA: 0x002316B8 File Offset: 0x0022F8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248177, XrefRangeEnd = 248188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteCocaineInstance(this Writer writer, CocaineInstance value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteCocaineInstance_Public_Static_Void_Writer_CocaineInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008422 RID: 33826 RVA: 0x00231700 File Offset: 0x0022F900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248188, XrefRangeEnd = 248190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CocaineInstance ReadCocaineInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadCocaineInstance_Public_Static_CocaineInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CocaineInstance>(intPtr3) : null;
		}

		// Token: 0x06008423 RID: 33827 RVA: 0x00231744 File Offset: 0x0022F944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248190, XrefRangeEnd = 248201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CocaineInstance DirectReadCocaineInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadCocaineInstance_Private_Static_CocaineInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CocaineInstance>(intPtr3) : null;
		}

		// Token: 0x06008424 RID: 33828 RVA: 0x00231788 File Offset: 0x0022F988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248201, XrefRangeEnd = 248211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteIntegerItemInstance(this Writer writer, IntegerItemInstance value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteIntegerItemInstance_Public_Static_Void_Writer_IntegerItemInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008425 RID: 33829 RVA: 0x002317D0 File Offset: 0x0022F9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248211, XrefRangeEnd = 248213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntegerItemInstance ReadIntegerItemInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadIntegerItemInstance_Public_Static_IntegerItemInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntegerItemInstance>(intPtr3) : null;
		}

		// Token: 0x06008426 RID: 33830 RVA: 0x00231814 File Offset: 0x0022FA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248213, XrefRangeEnd = 248222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntegerItemInstance DirectReadIntegerItemInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadIntegerItemInstance_Private_Static_IntegerItemInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntegerItemInstance>(intPtr3) : null;
		}

		// Token: 0x06008427 RID: 33831 RVA: 0x00231858 File Offset: 0x0022FA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248222, XrefRangeEnd = 248232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteWateringCanInstance(this Writer writer, WateringCanInstance value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteWateringCanInstance_Public_Static_Void_Writer_WateringCanInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008428 RID: 33832 RVA: 0x002318A0 File Offset: 0x0022FAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248232, XrefRangeEnd = 248234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WateringCanInstance ReadWateringCanInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadWateringCanInstance_Public_Static_WateringCanInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WateringCanInstance>(intPtr3) : null;
		}

		// Token: 0x06008429 RID: 33833 RVA: 0x002318E4 File Offset: 0x0022FAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248234, XrefRangeEnd = 248244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WateringCanInstance DirectReadWateringCanInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadWateringCanInstance_Private_Static_WateringCanInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WateringCanInstance>(intPtr3) : null;
		}

		// Token: 0x0600842A RID: 33834 RVA: 0x00231928 File Offset: 0x0022FB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248244, XrefRangeEnd = 248276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteTrashGrabberInstance(this Writer writer, TrashGrabberInstance value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteTrashGrabberInstance_Public_Static_Void_Writer_TrashGrabberInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600842B RID: 33835 RVA: 0x00231970 File Offset: 0x0022FB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248276, XrefRangeEnd = 248278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TrashGrabberInstance ReadTrashGrabberInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadTrashGrabberInstance_Public_Static_TrashGrabberInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashGrabberInstance>(intPtr3) : null;
		}

		// Token: 0x0600842C RID: 33836 RVA: 0x002319B4 File Offset: 0x0022FBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248278, XrefRangeEnd = 248313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TrashGrabberInstance DirectReadTrashGrabberInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_DirectReadTrashGrabberInstance_Private_Static_TrashGrabberInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashGrabberInstance>(intPtr3) : null;
		}

		// Token: 0x0600842D RID: 33837 RVA: 0x0003EB08 File Offset: 0x0003CD08
		public ItemSerializers(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027EF RID: 10223
		// (get) Token: 0x0600842E RID: 33838 RVA: 0x002319F8 File Offset: 0x0022FBF8
		// (set) Token: 0x0600842F RID: 33839 RVA: 0x0003EB11 File Offset: 0x0003CD11
		public unsafe static bool DEBUG
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(ItemSerializers.NativeFieldInfoPtr_DEBUG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemSerializers.NativeFieldInfoPtr_DEBUG, (void*)(&value));
			}
		}

		// Token: 0x040059DD RID: 23005
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x040059DE RID: 23006
		private static readonly IntPtr NativeMethodInfoPtr_Read_Private_Static_ItemInstance_Reader_0;

		// Token: 0x040059DF RID: 23007
		private static readonly IntPtr NativeMethodInfoPtr_WriteItemInstance_Public_Static_Void_Writer_ItemInstance_0;

		// Token: 0x040059E0 RID: 23008
		private static readonly IntPtr NativeMethodInfoPtr_ReadItemInstance_Public_Static_ItemInstance_Reader_0;

		// Token: 0x040059E1 RID: 23009
		private static readonly IntPtr NativeMethodInfoPtr_DirectReadItemInstance_Private_Static_ItemInstance_Reader_0;

		// Token: 0x040059E2 RID: 23010
		private static readonly IntPtr NativeMethodInfoPtr_WriteStorableItemInstance_Public_Static_Void_Writer_StorableItemInstance_0;

		// Token: 0x040059E3 RID: 23011
		private static readonly IntPtr NativeMethodInfoPtr_ReadStorableItemInstance_Public_Static_StorableItemInstance_Reader_0;

		// Token: 0x040059E4 RID: 23012
		private static readonly IntPtr NativeMethodInfoPtr_DirectReadStorableItemInstance_Private_Static_StorableItemInstance_Reader_0;

		// Token: 0x040059E5 RID: 23013
		private static readonly IntPtr NativeMethodInfoPtr_WriteCashInstance_Public_Static_Void_Writer_CashInstance_0;

		// Token: 0x040059E6 RID: 23014
		private static readonly IntPtr NativeMethodInfoPtr_ReadCashInstance_Public_Static_CashInstance_Reader_0;

		// Token: 0x040059E7 RID: 23015
		private static readonly IntPtr NativeMethodInfoPtr_DirectReadCashInstance_Private_Static_CashInstance_Reader_0;

		// Token: 0x040059E8 RID: 23016
		private static readonly IntPtr NativeMethodInfoPtr_WriteQualityItemInstance_Public_Static_Void_Writer_QualityItemInstance_0;

		// Token: 0x040059E9 RID: 23017
		private static readonly IntPtr NativeMethodInfoPtr_ReadQualityItemInstance_Public_Static_QualityItemInstance_Reader_0;

		// Token: 0x040059EA RID: 23018
		private static readonly IntPtr NativeMethodInfoPtr_DirectReadQualityItemInstance_Private_Static_QualityItemInstance_Reader_0;

		// Token: 0x040059EB RID: 23019
		private static readonly IntPtr NativeMethodInfoPtr_WriteClothingInstance_Public_Static_Void_Writer_ClothingInstance_0;

		// Token: 0x040059EC RID: 23020
		private static readonly IntPtr NativeMethodInfoPtr_ReadClothingInstance_Public_Static_ClothingInstance_Reader_0;

		// Token: 0x040059ED RID: 23021
		private static readonly IntPtr NativeMethodInfoPtr_DirectReadClothingInstance_Private_Static_ClothingInstance_Reader_0;

		// Token: 0x040059EE RID: 23022
		private static readonly IntPtr NativeMethodInfoPtr_WriteProductItemInstance_Public_Static_Void_Writer_ProductItemInstance_0;

		// Token: 0x040059EF RID: 23023
		private static readonly IntPtr NativeMethodInfoPtr_ReadProductItemInstance_Public_Static_ProductItemInstance_Reader_0;

		// Token: 0x040059F0 RID: 23024
		private static readonly IntPtr NativeMethodInfoPtr_DirectReadProductItemInstance_Private_Static_ProductItemInstance_Reader_0;

		// Token: 0x040059F1 RID: 23025
		private static readonly IntPtr NativeMethodInfoPtr_WriteWeedInstance_Public_Static_Void_Writer_WeedInstance_0;

		// Token: 0x040059F2 RID: 23026
		private static readonly IntPtr NativeMethodInfoPtr_ReadWeedInstance_Public_Static_WeedInstance_Reader_0;

		// Token: 0x040059F3 RID: 23027
		private static readonly IntPtr NativeMethodInfoPtr_DirectReadWeedInstance_Private_Static_WeedInstance_Reader_0;

		// Token: 0x040059F4 RID: 23028
		private static readonly IntPtr NativeMethodInfoPtr_WriteMethInstance_Public_Static_Void_Writer_MethInstance_0;

		// Token: 0x040059F5 RID: 23029
		private static readonly IntPtr NativeMethodInfoPtr_ReadMethInstance_Public_Static_MethInstance_Reader_0;

		// Token: 0x040059F6 RID: 23030
		private static readonly IntPtr NativeMethodInfoPtr_DirectReadMethInstance_Private_Static_MethInstance_Reader_0;

		// Token: 0x040059F7 RID: 23031
		private static readonly IntPtr NativeMethodInfoPtr_WriteCocaineInstance_Public_Static_Void_Writer_CocaineInstance_0;

		// Token: 0x040059F8 RID: 23032
		private static readonly IntPtr NativeMethodInfoPtr_ReadCocaineInstance_Public_Static_CocaineInstance_Reader_0;

		// Token: 0x040059F9 RID: 23033
		private static readonly IntPtr NativeMethodInfoPtr_DirectReadCocaineInstance_Private_Static_CocaineInstance_Reader_0;

		// Token: 0x040059FA RID: 23034
		private static readonly IntPtr NativeMethodInfoPtr_WriteIntegerItemInstance_Public_Static_Void_Writer_IntegerItemInstance_0;

		// Token: 0x040059FB RID: 23035
		private static readonly IntPtr NativeMethodInfoPtr_ReadIntegerItemInstance_Public_Static_IntegerItemInstance_Reader_0;

		// Token: 0x040059FC RID: 23036
		private static readonly IntPtr NativeMethodInfoPtr_DirectReadIntegerItemInstance_Private_Static_IntegerItemInstance_Reader_0;

		// Token: 0x040059FD RID: 23037
		private static readonly IntPtr NativeMethodInfoPtr_WriteWateringCanInstance_Public_Static_Void_Writer_WateringCanInstance_0;

		// Token: 0x040059FE RID: 23038
		private static readonly IntPtr NativeMethodInfoPtr_ReadWateringCanInstance_Public_Static_WateringCanInstance_Reader_0;

		// Token: 0x040059FF RID: 23039
		private static readonly IntPtr NativeMethodInfoPtr_DirectReadWateringCanInstance_Private_Static_WateringCanInstance_Reader_0;

		// Token: 0x04005A00 RID: 23040
		private static readonly IntPtr NativeMethodInfoPtr_WriteTrashGrabberInstance_Public_Static_Void_Writer_TrashGrabberInstance_0;

		// Token: 0x04005A01 RID: 23041
		private static readonly IntPtr NativeMethodInfoPtr_ReadTrashGrabberInstance_Public_Static_TrashGrabberInstance_Reader_0;

		// Token: 0x04005A02 RID: 23042
		private static readonly IntPtr NativeMethodInfoPtr_DirectReadTrashGrabberInstance_Private_Static_TrashGrabberInstance_Reader_0;
	}
}
