using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006D7 RID: 1751
	public class CauldronUIElement : WorldspaceUIElement
	{
		// Token: 0x06009D8E RID: 40334 RVA: 0x0027D880 File Offset: 0x0027BA80
		// Note: this type is marked as 'beforefieldinit'.
		static CauldronUIElement()
		{
			Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "CauldronUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr);
			CauldronUIElement.NativeFieldInfoPtr__AssignedCauldron_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr, "<AssignedCauldron>k__BackingField");
			CauldronUIElement.NativeMethodInfoPtr_get_AssignedCauldron_Public_get_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr, 100682621);
			CauldronUIElement.NativeMethodInfoPtr_set_AssignedCauldron_Protected_set_Void_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr, 100682622);
			CauldronUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr, 100682623);
			CauldronUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr, 100682624);
			CauldronUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr, 100682625);
		}

		// Token: 0x17003089 RID: 12425
		// (get) Token: 0x06009D8F RID: 40335 RVA: 0x0027D928 File Offset: 0x0027BB28
		// (set) Token: 0x06009D90 RID: 40336 RVA: 0x0027D968 File Offset: 0x0027BB68
		public unsafe Cauldron AssignedCauldron
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16596, RefRangeEnd = 16597, XrefRangeStart = 16596, XrefRangeEnd = 16597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronUIElement.NativeMethodInfoPtr_get_AssignedCauldron_Public_get_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cauldron>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 38372, RefRangeEnd = 38373, XrefRangeStart = 38372, XrefRangeEnd = 38373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronUIElement.NativeMethodInfoPtr_set_AssignedCauldron_Protected_set_Void_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009D91 RID: 40337 RVA: 0x0027D9AC File Offset: 0x0027BBAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279417, RefRangeEnd = 279418, XrefRangeStart = 279407, XrefRangeEnd = 279417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Cauldron cauldron)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cauldron);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D92 RID: 40338 RVA: 0x0027D9F0 File Offset: 0x0027BBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279418, XrefRangeEnd = 279424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CauldronUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D93 RID: 40339 RVA: 0x0027DA2C File Offset: 0x0027BC2C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CauldronUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CauldronUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D94 RID: 40340 RVA: 0x0004D526 File Offset: 0x0004B726
		public CauldronUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003088 RID: 12424
		// (get) Token: 0x06009D95 RID: 40341 RVA: 0x0027DA68 File Offset: 0x0027BC68
		// (set) Token: 0x06009D96 RID: 40342 RVA: 0x0004D52F File Offset: 0x0004B72F
		public unsafe Cauldron _AssignedCauldron_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronUIElement.NativeFieldInfoPtr__AssignedCauldron_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cauldron>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronUIElement.NativeFieldInfoPtr__AssignedCauldron_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040069CA RID: 27082
		private static readonly IntPtr NativeFieldInfoPtr__AssignedCauldron_k__BackingField;

		// Token: 0x040069CB RID: 27083
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedCauldron_Public_get_Cauldron_0;

		// Token: 0x040069CC RID: 27084
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedCauldron_Protected_set_Void_Cauldron_0;

		// Token: 0x040069CD RID: 27085
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Cauldron_0;

		// Token: 0x040069CE RID: 27086
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x040069CF RID: 27087
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
