using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002B3 RID: 691
	[Serializable]
	public class SaveData : Object
	{
		// Token: 0x0600319F RID: 12703 RVA: 0x0010DE20 File Offset: 0x0010C020
		// Note: this type is marked as 'beforefieldinit'.
		static SaveData()
		{
			Il2CppClassPointerStore<SaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "SaveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveData>.NativeClassPtr);
			SaveData.NativeFieldInfoPtr_DataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData>.NativeClassPtr, "DataType");
			SaveData.NativeFieldInfoPtr_DataVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData>.NativeClassPtr, "DataVersion");
			SaveData.NativeFieldInfoPtr_GameVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData>.NativeClassPtr, "GameVersion");
			SaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveData>.NativeClassPtr, 100668842);
			SaveData.NativeMethodInfoPtr_GetDataVersion_Protected_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveData>.NativeClassPtr, 100668843);
			SaveData.NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveData>.NativeClassPtr, 100668844);
		}

		// Token: 0x060031A0 RID: 12704 RVA: 0x0010DEC8 File Offset: 0x0010C0C8
		[CallerCount(102)]
		[CachedScanResults(RefRangeStart = 131054, RefRangeEnd = 131156, XrefRangeStart = 131040, XrefRangeEnd = 131054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031A1 RID: 12705 RVA: 0x0010DF04 File Offset: 0x0010C104
		[CallerCount(65)]
		[CachedScanResults(RefRangeStart = 31226, RefRangeEnd = 31291, XrefRangeStart = 31226, XrefRangeEnd = 31291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetDataVersion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SaveData.NativeMethodInfoPtr_GetDataVersion_Protected_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060031A2 RID: 12706 RVA: 0x0010DF4C File Offset: 0x0010C14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131156, XrefRangeEnd = 131168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetJson(bool prettyPrint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref prettyPrint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SaveData.NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060031A3 RID: 12707 RVA: 0x0001A8F9 File Offset: 0x00018AF9
		public SaveData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x060031A4 RID: 12708 RVA: 0x0010DF9C File Offset: 0x0010C19C
		// (set) Token: 0x060031A5 RID: 12709 RVA: 0x0001A902 File Offset: 0x00018B02
		public unsafe string DataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_DataType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_DataType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x060031A6 RID: 12710 RVA: 0x0010DFC4 File Offset: 0x0010C1C4
		// (set) Token: 0x060031A7 RID: 12711 RVA: 0x0001A921 File Offset: 0x00018B21
		public unsafe int DataVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_DataVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_DataVersion)) = value;
			}
		}

		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x060031A8 RID: 12712 RVA: 0x0010DFEC File Offset: 0x0010C1EC
		// (set) Token: 0x060031A9 RID: 12713 RVA: 0x0001A93C File Offset: 0x00018B3C
		public unsafe string GameVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_GameVersion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_GameVersion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400203B RID: 8251
		private static readonly IntPtr NativeFieldInfoPtr_DataType;

		// Token: 0x0400203C RID: 8252
		private static readonly IntPtr NativeFieldInfoPtr_DataVersion;

		// Token: 0x0400203D RID: 8253
		private static readonly IntPtr NativeFieldInfoPtr_GameVersion;

		// Token: 0x0400203E RID: 8254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400203F RID: 8255
		private static readonly IntPtr NativeMethodInfoPtr_GetDataVersion_Protected_Virtual_New_Int32_0;

		// Token: 0x04002040 RID: 8256
		private static readonly IntPtr NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0;
	}
}
