using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003C2 RID: 962
	[Serializable]
	public class Crime : Object
	{
		// Token: 0x06004B06 RID: 19206 RVA: 0x0016B1D0 File Offset: 0x001693D0
		// Note: this type is marked as 'beforefieldinit'.
		static Crime()
		{
			Il2CppClassPointerStore<Crime>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "Crime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Crime>.NativeClassPtr);
			Crime.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Crime>.NativeClassPtr, "<CrimeName>k__BackingField");
			Crime.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Crime>.NativeClassPtr, 100672597);
			Crime.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Crime>.NativeClassPtr, 100672598);
			Crime.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Crime>.NativeClassPtr, 100672599);
		}

		// Token: 0x1700167E RID: 5758
		// (get) Token: 0x06004B07 RID: 19207 RVA: 0x0016B250 File Offset: 0x00169450
		// (set) Token: 0x06004B08 RID: 19208 RVA: 0x0016B294 File Offset: 0x00169494
		public unsafe virtual string CrimeName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 17383, RefRangeEnd = 17393, XrefRangeStart = 17383, XrefRangeEnd = 17393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Crime.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29994, RefRangeEnd = 29996, XrefRangeStart = 29994, XrefRangeEnd = 29996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Crime.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B09 RID: 19209 RVA: 0x0016B2E4 File Offset: 0x001694E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164600, RefRangeEnd = 164601, XrefRangeStart = 164595, XrefRangeEnd = 164600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Crime() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Crime>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Crime.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B0A RID: 19210 RVA: 0x0002422F File Offset: 0x0002242F
		public Crime(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700167D RID: 5757
		// (get) Token: 0x06004B0B RID: 19211 RVA: 0x0016B320 File Offset: 0x00169520
		// (set) Token: 0x06004B0C RID: 19212 RVA: 0x00024238 File Offset: 0x00022438
		public unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Crime.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Crime.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400329F RID: 12959
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032A0 RID: 12960
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_New_get_String_0;

		// Token: 0x040032A1 RID: 12961
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_New_set_Void_String_0;

		// Token: 0x040032A2 RID: 12962
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
