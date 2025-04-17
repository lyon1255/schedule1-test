﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x0200021F RID: 543
	public class SaveInfo : Object
	{
		// Token: 0x06002D26 RID: 11558 RVA: 0x000FFFF4 File Offset: 0x000FE1F4
		// Note: this type is marked as 'beforefieldinit'.
		static SaveInfo()
		{
			Il2CppClassPointerStore<SaveInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "SaveInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr);
			SaveInfo.NativeFieldInfoPtr_SavePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, "SavePath");
			SaveInfo.NativeFieldInfoPtr_SaveSlotNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, "SaveSlotNumber");
			SaveInfo.NativeFieldInfoPtr_OrganisationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, "OrganisationName");
			SaveInfo.NativeFieldInfoPtr_DateCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, "DateCreated");
			SaveInfo.NativeFieldInfoPtr_DateLastPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, "DateLastPlayed");
			SaveInfo.NativeFieldInfoPtr_Networth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, "Networth");
			SaveInfo.NativeFieldInfoPtr_SaveVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, "SaveVersion");
			SaveInfo.NativeFieldInfoPtr_MetaData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, "MetaData");
			SaveInfo.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_DateTime_DateTime_Single_String_MetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, 100668472);
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x001000D8 File Offset: 0x000FE2D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 126476, RefRangeEnd = 126478, XrefRangeStart = 126471, XrefRangeEnd = 126476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveInfo(string savePath, int saveSlotNumber, string organisationName, DateTime dateCreated, DateTime dateLastPlayed, float networth, string saveVersion, MetaData metaData) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(savePath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref saveSlotNumber;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(organisationName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateCreated;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dateLastPlayed;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref networth;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(saveVersion);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(metaData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveInfo.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_DateTime_DateTime_Single_String_MetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x000183DF File Offset: 0x000165DF
		public SaveInfo(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x06002D29 RID: 11561 RVA: 0x00100194 File Offset: 0x000FE394
		// (set) Token: 0x06002D2A RID: 11562 RVA: 0x000183E8 File Offset: 0x000165E8
		public unsafe string SavePath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_SavePath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_SavePath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x06002D2B RID: 11563 RVA: 0x001001BC File Offset: 0x000FE3BC
		// (set) Token: 0x06002D2C RID: 11564 RVA: 0x00018407 File Offset: 0x00016607
		public unsafe int SaveSlotNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_SaveSlotNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_SaveSlotNumber)) = value;
			}
		}

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x06002D2D RID: 11565 RVA: 0x001001E4 File Offset: 0x000FE3E4
		// (set) Token: 0x06002D2E RID: 11566 RVA: 0x00018422 File Offset: 0x00016622
		public unsafe string OrganisationName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_OrganisationName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_OrganisationName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x06002D2F RID: 11567 RVA: 0x0010020C File Offset: 0x000FE40C
		// (set) Token: 0x06002D30 RID: 11568 RVA: 0x00018441 File Offset: 0x00016641
		public unsafe DateTime DateCreated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_DateCreated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_DateCreated)) = value;
			}
		}

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x06002D31 RID: 11569 RVA: 0x00100234 File Offset: 0x000FE434
		// (set) Token: 0x06002D32 RID: 11570 RVA: 0x0001845C File Offset: 0x0001665C
		public unsafe DateTime DateLastPlayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_DateLastPlayed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_DateLastPlayed)) = value;
			}
		}

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x06002D33 RID: 11571 RVA: 0x0010025C File Offset: 0x000FE45C
		// (set) Token: 0x06002D34 RID: 11572 RVA: 0x00018477 File Offset: 0x00016677
		public unsafe float Networth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_Networth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_Networth)) = value;
			}
		}

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x06002D35 RID: 11573 RVA: 0x00100284 File Offset: 0x000FE484
		// (set) Token: 0x06002D36 RID: 11574 RVA: 0x00018492 File Offset: 0x00016692
		public unsafe string SaveVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_SaveVersion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_SaveVersion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x06002D37 RID: 11575 RVA: 0x001002AC File Offset: 0x000FE4AC
		// (set) Token: 0x06002D38 RID: 11576 RVA: 0x000184B1 File Offset: 0x000166B1
		public unsafe MetaData MetaData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_MetaData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MetaData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_MetaData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001DFD RID: 7677
		private static readonly IntPtr NativeFieldInfoPtr_SavePath;

		// Token: 0x04001DFE RID: 7678
		private static readonly IntPtr NativeFieldInfoPtr_SaveSlotNumber;

		// Token: 0x04001DFF RID: 7679
		private static readonly IntPtr NativeFieldInfoPtr_OrganisationName;

		// Token: 0x04001E00 RID: 7680
		private static readonly IntPtr NativeFieldInfoPtr_DateCreated;

		// Token: 0x04001E01 RID: 7681
		private static readonly IntPtr NativeFieldInfoPtr_DateLastPlayed;

		// Token: 0x04001E02 RID: 7682
		private static readonly IntPtr NativeFieldInfoPtr_Networth;

		// Token: 0x04001E03 RID: 7683
		private static readonly IntPtr NativeFieldInfoPtr_SaveVersion;

		// Token: 0x04001E04 RID: 7684
		private static readonly IntPtr NativeFieldInfoPtr_MetaData;

		// Token: 0x04001E05 RID: 7685
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_DateTime_DateTime_Single_String_MetaData_0;
	}
}
