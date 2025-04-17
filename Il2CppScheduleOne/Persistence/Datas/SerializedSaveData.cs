using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002B4 RID: 692
	[Serializable]
	public class SerializedSaveData : Object
	{
		// Token: 0x060031AA RID: 12714 RVA: 0x0010E014 File Offset: 0x0010C214
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedSaveData()
		{
			Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "SerializedSaveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr);
			SerializedSaveData.NativeFieldInfoPtr__DataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr, "_DataType");
			SerializedSaveData.NativeFieldInfoPtr_DataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr, "DataType");
			SerializedSaveData.NativeFieldInfoPtr__DataVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr, "_DataVersion");
			SerializedSaveData.NativeFieldInfoPtr_DataVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr, "DataVersion");
			SerializedSaveData.NativeMethodInfoPtr_get_Version_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr, 100668845);
			SerializedSaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr, 100668846);
		}

		// Token: 0x1700103A RID: 4154
		// (get) Token: 0x060031AB RID: 12715 RVA: 0x0010E0BC File Offset: 0x0010C2BC
		public unsafe string Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131168, XrefRangeEnd = 131172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedSaveData.NativeMethodInfoPtr_get_Version_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060031AC RID: 12716 RVA: 0x0010E0F4 File Offset: 0x0010C2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131172, XrefRangeEnd = 131177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedSaveData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedSaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031AD RID: 12717 RVA: 0x0001A95B File Offset: 0x00018B5B
		public SerializedSaveData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x060031AE RID: 12718 RVA: 0x0010E130 File Offset: 0x0010C330
		// (set) Token: 0x060031AF RID: 12719 RVA: 0x0001A964 File Offset: 0x00018B64
		public unsafe static string _DataType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SerializedSaveData.NativeFieldInfoPtr__DataType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializedSaveData.NativeFieldInfoPtr__DataType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x060031B0 RID: 12720 RVA: 0x0010E150 File Offset: 0x0010C350
		// (set) Token: 0x060031B1 RID: 12721 RVA: 0x0001A976 File Offset: 0x00018B76
		public unsafe string DataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSaveData.NativeFieldInfoPtr_DataType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSaveData.NativeFieldInfoPtr_DataType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x060031B2 RID: 12722 RVA: 0x0010E178 File Offset: 0x0010C378
		// (set) Token: 0x060031B3 RID: 12723 RVA: 0x0001A995 File Offset: 0x00018B95
		public unsafe static int _DataVersion
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SerializedSaveData.NativeFieldInfoPtr__DataVersion, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializedSaveData.NativeFieldInfoPtr__DataVersion, (void*)(&value));
			}
		}

		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x060031B4 RID: 12724 RVA: 0x0010E194 File Offset: 0x0010C394
		// (set) Token: 0x060031B5 RID: 12725 RVA: 0x0001A9A3 File Offset: 0x00018BA3
		public unsafe int DataVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSaveData.NativeFieldInfoPtr_DataVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSaveData.NativeFieldInfoPtr_DataVersion)) = value;
			}
		}

		// Token: 0x04002041 RID: 8257
		private static readonly IntPtr NativeFieldInfoPtr__DataType;

		// Token: 0x04002042 RID: 8258
		private static readonly IntPtr NativeFieldInfoPtr_DataType;

		// Token: 0x04002043 RID: 8259
		private static readonly IntPtr NativeFieldInfoPtr__DataVersion;

		// Token: 0x04002044 RID: 8260
		private static readonly IntPtr NativeFieldInfoPtr_DataVersion;

		// Token: 0x04002045 RID: 8261
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_String_0;

		// Token: 0x04002046 RID: 8262
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
