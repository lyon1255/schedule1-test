using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003C7 RID: 967
	[Serializable]
	public class Evading : Crime
	{
		// Token: 0x06004B29 RID: 19241 RVA: 0x0016B928 File Offset: 0x00169B28
		// Note: this type is marked as 'beforefieldinit'.
		static Evading()
		{
			Il2CppClassPointerStore<Evading>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "Evading");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Evading>.NativeClassPtr);
			Evading.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Evading>.NativeClassPtr, "<CrimeName>k__BackingField");
			Evading.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evading>.NativeClassPtr, 100672612);
			Evading.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evading>.NativeClassPtr, 100672613);
			Evading.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evading>.NativeClassPtr, 100672614);
		}

		// Token: 0x17001688 RID: 5768
		// (get) Token: 0x06004B2A RID: 19242 RVA: 0x0016B9A8 File Offset: 0x00169BA8
		// (set) Token: 0x06004B2B RID: 19243 RVA: 0x0016B9EC File Offset: 0x00169BEC
		public unsafe override string CrimeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Evading.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Evading.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B2C RID: 19244 RVA: 0x0016BA3C File Offset: 0x00169C3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164650, RefRangeEnd = 164651, XrefRangeStart = 164641, XrefRangeEnd = 164650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Evading() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Evading>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Evading.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B2D RID: 19245 RVA: 0x000242F7 File Offset: 0x000224F7
		public Evading(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001687 RID: 5767
		// (get) Token: 0x06004B2E RID: 19246 RVA: 0x0016BA78 File Offset: 0x00169C78
		// (set) Token: 0x06004B2F RID: 19247 RVA: 0x00024300 File Offset: 0x00022500
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evading.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Evading.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032B3 RID: 12979
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032B4 RID: 12980
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040032B5 RID: 12981
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040032B6 RID: 12982
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
