using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vision
{
	// Token: 0x02000178 RID: 376
	[Serializable]
	public class VisionEventReceipt : Object
	{
		// Token: 0x06001E6D RID: 7789 RVA: 0x000CF054 File Offset: 0x000CD254
		// Note: this type is marked as 'beforefieldinit'.
		static VisionEventReceipt()
		{
			Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vision", "VisionEventReceipt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr);
			VisionEventReceipt.NativeFieldInfoPtr_TargetPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr, "TargetPlayer");
			VisionEventReceipt.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr, "State");
			VisionEventReceipt.NativeMethodInfoPtr__ctor_Public_Void_NetworkObject_EVisualState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr, 100666745);
			VisionEventReceipt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr, 100666746);
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x000CF0D4 File Offset: 0x000CD2D4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 107228, RefRangeEnd = 107237, XrefRangeStart = 107226, XrefRangeEnd = 107228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisionEventReceipt(NetworkObject targetPlayer, PlayerVisualState.EVisualState state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetPlayer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEventReceipt.NativeMethodInfoPtr__ctor_Public_Void_NetworkObject_EVisualState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x000CF130 File Offset: 0x000CD330
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisionEventReceipt() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionEventReceipt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionEventReceipt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x000112B5 File Offset: 0x0000F4B5
		public VisionEventReceipt(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06001E71 RID: 7793 RVA: 0x000CF16C File Offset: 0x000CD36C
		// (set) Token: 0x06001E72 RID: 7794 RVA: 0x000112BE File Offset: 0x0000F4BE
		public unsafe NetworkObject TargetPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEventReceipt.NativeFieldInfoPtr_TargetPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEventReceipt.NativeFieldInfoPtr_TargetPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06001E73 RID: 7795 RVA: 0x000CF19C File Offset: 0x000CD39C
		// (set) Token: 0x06001E74 RID: 7796 RVA: 0x000112DD File Offset: 0x0000F4DD
		public unsafe PlayerVisualState.EVisualState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEventReceipt.NativeFieldInfoPtr_State);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionEventReceipt.NativeFieldInfoPtr_State)) = value;
			}
		}

		// Token: 0x04001438 RID: 5176
		private static readonly IntPtr NativeFieldInfoPtr_TargetPlayer;

		// Token: 0x04001439 RID: 5177
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x0400143A RID: 5178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NetworkObject_EVisualState_0;

		// Token: 0x0400143B RID: 5179
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
