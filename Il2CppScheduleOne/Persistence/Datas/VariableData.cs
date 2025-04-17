using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002BD RID: 701
	[Serializable]
	public class VariableData : SaveData
	{
		// Token: 0x060031F6 RID: 12790 RVA: 0x0010EC1C File Offset: 0x0010CE1C
		// Note: this type is marked as 'beforefieldinit'.
		static VariableData()
		{
			Il2CppClassPointerStore<VariableData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "VariableData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariableData>.NativeClassPtr);
			VariableData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableData>.NativeClassPtr, "Name");
			VariableData.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableData>.NativeClassPtr, "Value");
			VariableData.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableData>.NativeClassPtr, 100668857);
			VariableData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableData>.NativeClassPtr, 100668858);
		}

		// Token: 0x060031F7 RID: 12791 RVA: 0x0010EC9C File Offset: 0x0010CE9C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 130629, RefRangeEnd = 130638, XrefRangeStart = 130629, XrefRangeEnd = 130638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VariableData(string name, string value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariableData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableData.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031F8 RID: 12792 RVA: 0x0010ECFC File Offset: 0x0010CEFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131215, RefRangeEnd = 131216, XrefRangeStart = 131207, XrefRangeEnd = 131215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VariableData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariableData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VariableData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031F9 RID: 12793 RVA: 0x0001AC6C File Offset: 0x00018E6C
		public VariableData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x060031FA RID: 12794 RVA: 0x0010ED38 File Offset: 0x0010CF38
		// (set) Token: 0x060031FB RID: 12795 RVA: 0x0001AC75 File Offset: 0x00018E75
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableData.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x060031FC RID: 12796 RVA: 0x0010ED60 File Offset: 0x0010CF60
		// (set) Token: 0x060031FD RID: 12797 RVA: 0x0001AC94 File Offset: 0x00018E94
		public unsafe string Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableData.NativeFieldInfoPtr_Value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VariableData.NativeFieldInfoPtr_Value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002064 RID: 8292
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04002065 RID: 8293
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04002066 RID: 8294
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x04002067 RID: 8295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
