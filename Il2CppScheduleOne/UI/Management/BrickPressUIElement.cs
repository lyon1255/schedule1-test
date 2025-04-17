using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006D6 RID: 1750
	public class BrickPressUIElement : WorldspaceUIElement
	{
		// Token: 0x06009D85 RID: 40325 RVA: 0x0027D668 File Offset: 0x0027B868
		// Note: this type is marked as 'beforefieldinit'.
		static BrickPressUIElement()
		{
			Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "BrickPressUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr);
			BrickPressUIElement.NativeFieldInfoPtr__AssignedPress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr, "<AssignedPress>k__BackingField");
			BrickPressUIElement.NativeMethodInfoPtr_get_AssignedPress_Public_get_BrickPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr, 100682616);
			BrickPressUIElement.NativeMethodInfoPtr_set_AssignedPress_Protected_set_Void_BrickPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr, 100682617);
			BrickPressUIElement.NativeMethodInfoPtr_Initialize_Public_Void_BrickPress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr, 100682618);
			BrickPressUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr, 100682619);
			BrickPressUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr, 100682620);
		}

		// Token: 0x17003087 RID: 12423
		// (get) Token: 0x06009D86 RID: 40326 RVA: 0x0027D710 File Offset: 0x0027B910
		// (set) Token: 0x06009D87 RID: 40327 RVA: 0x0027D750 File Offset: 0x0027B950
		public unsafe BrickPress AssignedPress
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16596, RefRangeEnd = 16597, XrefRangeStart = 16596, XrefRangeEnd = 16597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressUIElement.NativeMethodInfoPtr_get_AssignedPress_Public_get_BrickPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BrickPress>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 38372, RefRangeEnd = 38373, XrefRangeStart = 38372, XrefRangeEnd = 38373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressUIElement.NativeMethodInfoPtr_set_AssignedPress_Protected_set_Void_BrickPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009D88 RID: 40328 RVA: 0x0027D794 File Offset: 0x0027B994
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279400, RefRangeEnd = 279401, XrefRangeStart = 279390, XrefRangeEnd = 279400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(BrickPress press)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(press);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressUIElement.NativeMethodInfoPtr_Initialize_Public_Void_BrickPress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D89 RID: 40329 RVA: 0x0027D7D8 File Offset: 0x0027B9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279401, XrefRangeEnd = 279407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrickPressUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D8A RID: 40330 RVA: 0x0027D814 File Offset: 0x0027BA14
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrickPressUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrickPressUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D8B RID: 40331 RVA: 0x0004D4FE File Offset: 0x0004B6FE
		public BrickPressUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003086 RID: 12422
		// (get) Token: 0x06009D8C RID: 40332 RVA: 0x0027D850 File Offset: 0x0027BA50
		// (set) Token: 0x06009D8D RID: 40333 RVA: 0x0004D507 File Offset: 0x0004B707
		public unsafe BrickPress _AssignedPress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressUIElement.NativeFieldInfoPtr__AssignedPress_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BrickPress>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressUIElement.NativeFieldInfoPtr__AssignedPress_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040069C4 RID: 27076
		private static readonly IntPtr NativeFieldInfoPtr__AssignedPress_k__BackingField;

		// Token: 0x040069C5 RID: 27077
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedPress_Public_get_BrickPress_0;

		// Token: 0x040069C6 RID: 27078
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedPress_Protected_set_Void_BrickPress_0;

		// Token: 0x040069C7 RID: 27079
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_BrickPress_0;

		// Token: 0x040069C8 RID: 27080
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x040069C9 RID: 27081
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
