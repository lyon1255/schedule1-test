using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003CD RID: 973
	[Serializable]
	public class AttemptingToSell : Crime
	{
		// Token: 0x06004B53 RID: 19283 RVA: 0x0016C1F8 File Offset: 0x0016A3F8
		// Note: this type is marked as 'beforefieldinit'.
		static AttemptingToSell()
		{
			Il2CppClassPointerStore<AttemptingToSell>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "AttemptingToSell");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttemptingToSell>.NativeClassPtr);
			AttemptingToSell.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttemptingToSell>.NativeClassPtr, "<CrimeName>k__BackingField");
			AttemptingToSell.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttemptingToSell>.NativeClassPtr, 100672630);
			AttemptingToSell.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttemptingToSell>.NativeClassPtr, 100672631);
			AttemptingToSell.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttemptingToSell>.NativeClassPtr, 100672632);
		}

		// Token: 0x17001694 RID: 5780
		// (get) Token: 0x06004B54 RID: 19284 RVA: 0x0016C278 File Offset: 0x0016A478
		// (set) Token: 0x06004B55 RID: 19285 RVA: 0x0016C2BC File Offset: 0x0016A4BC
		public unsafe override string CrimeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttemptingToSell.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttemptingToSell.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B56 RID: 19286 RVA: 0x0016C30C File Offset: 0x0016A50C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164713, RefRangeEnd = 164714, XrefRangeStart = 164704, XrefRangeEnd = 164713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttemptingToSell() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttemptingToSell>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttemptingToSell.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B57 RID: 19287 RVA: 0x000243E7 File Offset: 0x000225E7
		public AttemptingToSell(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001693 RID: 5779
		// (get) Token: 0x06004B58 RID: 19288 RVA: 0x0016C348 File Offset: 0x0016A548
		// (set) Token: 0x06004B59 RID: 19289 RVA: 0x000243F0 File Offset: 0x000225F0
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttemptingToSell.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttemptingToSell.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032CB RID: 13003
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032CC RID: 13004
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040032CD RID: 13005
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040032CE RID: 13006
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
