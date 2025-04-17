using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005D2 RID: 1490
	public class ClipboardSlot : HotbarSlot
	{
		// Token: 0x06008328 RID: 33576 RVA: 0x0022DF10 File Offset: 0x0022C110
		// Note: this type is marked as 'beforefieldinit'.
		static ClipboardSlot()
		{
			Il2CppClassPointerStore<ClipboardSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ClipboardSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipboardSlot>.NativeClassPtr);
			ClipboardSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardSlot>.NativeClassPtr, 100679704);
			ClipboardSlot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipboardSlot>.NativeClassPtr, 100679705);
		}

		// Token: 0x06008329 RID: 33577 RVA: 0x0022DF68 File Offset: 0x0022C168
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ClearStoredInstance(bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClipboardSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600832A RID: 33578 RVA: 0x0022DFB4 File Offset: 0x0022C1B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 246958, RefRangeEnd = 246960, XrefRangeStart = 246957, XrefRangeEnd = 246958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClipboardSlot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipboardSlot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClipboardSlot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600832B RID: 33579 RVA: 0x0003E557 File Offset: 0x0003C757
		public ClipboardSlot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400593E RID: 22846
		private static readonly IntPtr NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_Void_Boolean_0;

		// Token: 0x0400593F RID: 22847
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
