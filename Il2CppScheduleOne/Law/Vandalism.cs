using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003D0 RID: 976
	[Serializable]
	public class Vandalism : Crime
	{
		// Token: 0x06004B68 RID: 19304 RVA: 0x0016C660 File Offset: 0x0016A860
		// Note: this type is marked as 'beforefieldinit'.
		static Vandalism()
		{
			Il2CppClassPointerStore<Vandalism>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "Vandalism");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vandalism>.NativeClassPtr);
			Vandalism.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vandalism>.NativeClassPtr, "<CrimeName>k__BackingField");
			Vandalism.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vandalism>.NativeClassPtr, 100672639);
			Vandalism.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vandalism>.NativeClassPtr, 100672640);
			Vandalism.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vandalism>.NativeClassPtr, 100672641);
		}

		// Token: 0x1700169A RID: 5786
		// (get) Token: 0x06004B69 RID: 19305 RVA: 0x0016C6E0 File Offset: 0x0016A8E0
		// (set) Token: 0x06004B6A RID: 19306 RVA: 0x0016C724 File Offset: 0x0016A924
		public unsafe override string CrimeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vandalism.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Vandalism.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B6B RID: 19307 RVA: 0x0016C774 File Offset: 0x0016A974
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164745, RefRangeEnd = 164746, XrefRangeStart = 164736, XrefRangeEnd = 164745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vandalism() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Vandalism>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vandalism.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B6C RID: 19308 RVA: 0x0002445F File Offset: 0x0002265F
		public Vandalism(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001699 RID: 5785
		// (get) Token: 0x06004B6D RID: 19309 RVA: 0x0016C7B0 File Offset: 0x0016A9B0
		// (set) Token: 0x06004B6E RID: 19310 RVA: 0x00024468 File Offset: 0x00022668
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vandalism.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Vandalism.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032D7 RID: 13015
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032D8 RID: 13016
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040032D9 RID: 13017
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040032DA RID: 13018
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
