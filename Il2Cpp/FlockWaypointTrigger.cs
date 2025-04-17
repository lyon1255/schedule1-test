using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200003B RID: 59
	public class FlockWaypointTrigger : MonoBehaviour
	{
		// Token: 0x060004D9 RID: 1241 RVA: 0x0007E76C File Offset: 0x0007C96C
		// Note: this type is marked as 'beforefieldinit'.
		static FlockWaypointTrigger()
		{
			Il2CppClassPointerStore<FlockWaypointTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FlockWaypointTrigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlockWaypointTrigger>.NativeClassPtr);
			FlockWaypointTrigger.NativeFieldInfoPtr__timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockWaypointTrigger>.NativeClassPtr, "_timer");
			FlockWaypointTrigger.NativeFieldInfoPtr__flockChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlockWaypointTrigger>.NativeClassPtr, "_flockChild");
			FlockWaypointTrigger.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockWaypointTrigger>.NativeClassPtr, 100663698);
			FlockWaypointTrigger.NativeMethodInfoPtr_Trigger_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockWaypointTrigger>.NativeClassPtr, 100663699);
			FlockWaypointTrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlockWaypointTrigger>.NativeClassPtr, 100663700);
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0007E800 File Offset: 0x0007CA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74351, XrefRangeEnd = 74365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockWaypointTrigger.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0007E834 File Offset: 0x0007CA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74365, XrefRangeEnd = 74367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Trigger()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockWaypointTrigger.NativeMethodInfoPtr_Trigger_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0007E868 File Offset: 0x0007CA68
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 74368, RefRangeEnd = 74372, XrefRangeStart = 74367, XrefRangeEnd = 74368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlockWaypointTrigger() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlockWaypointTrigger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlockWaypointTrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00004E52 File Offset: 0x00003052
		public FlockWaypointTrigger(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x0007E8A4 File Offset: 0x0007CAA4
		// (set) Token: 0x060004DF RID: 1247 RVA: 0x00004E5B File Offset: 0x0000305B
		public unsafe float _timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockWaypointTrigger.NativeFieldInfoPtr__timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockWaypointTrigger.NativeFieldInfoPtr__timer)) = value;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x0007E8CC File Offset: 0x0007CACC
		// (set) Token: 0x060004E1 RID: 1249 RVA: 0x00004E76 File Offset: 0x00003076
		public unsafe FlockChild _flockChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockWaypointTrigger.NativeFieldInfoPtr__flockChild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlockChild>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlockWaypointTrigger.NativeFieldInfoPtr__flockChild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeFieldInfoPtr__timer;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeFieldInfoPtr__flockChild;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeMethodInfoPtr_Trigger_Public_Void_0;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
