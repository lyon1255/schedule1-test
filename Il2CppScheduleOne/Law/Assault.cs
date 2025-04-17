using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003CE RID: 974
	[Serializable]
	public class Assault : Crime
	{
		// Token: 0x06004B5A RID: 19290 RVA: 0x0016C370 File Offset: 0x0016A570
		// Note: this type is marked as 'beforefieldinit'.
		static Assault()
		{
			Il2CppClassPointerStore<Assault>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "Assault");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Assault>.NativeClassPtr);
			Assault.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Assault>.NativeClassPtr, "<CrimeName>k__BackingField");
			Assault.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assault>.NativeClassPtr, 100672633);
			Assault.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assault>.NativeClassPtr, 100672634);
			Assault.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Assault>.NativeClassPtr, 100672635);
		}

		// Token: 0x17001696 RID: 5782
		// (get) Token: 0x06004B5B RID: 19291 RVA: 0x0016C3F0 File Offset: 0x0016A5F0
		// (set) Token: 0x06004B5C RID: 19292 RVA: 0x0016C434 File Offset: 0x0016A634
		public unsafe override string CrimeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assault.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Assault.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B5D RID: 19293 RVA: 0x0016C484 File Offset: 0x0016A684
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 164723, RefRangeEnd = 164726, XrefRangeStart = 164714, XrefRangeEnd = 164723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Assault() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Assault>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Assault.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B5E RID: 19294 RVA: 0x0002440F File Offset: 0x0002260F
		public Assault(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001695 RID: 5781
		// (get) Token: 0x06004B5F RID: 19295 RVA: 0x0016C4C0 File Offset: 0x0016A6C0
		// (set) Token: 0x06004B60 RID: 19296 RVA: 0x00024418 File Offset: 0x00022618
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Assault.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Assault.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032CF RID: 13007
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032D0 RID: 13008
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040032D1 RID: 13009
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040032D2 RID: 13010
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
