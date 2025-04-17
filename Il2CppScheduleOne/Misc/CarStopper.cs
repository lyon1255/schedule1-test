using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.AI;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x02000769 RID: 1897
	public class CarStopper : MonoBehaviour
	{
		// Token: 0x0600B40B RID: 46091 RVA: 0x002CDA70 File Offset: 0x002CBC70
		// Note: this type is marked as 'beforefieldinit'.
		static CarStopper()
		{
			Il2CppClassPointerStore<CarStopper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "CarStopper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarStopper>.NativeClassPtr);
			CarStopper.NativeFieldInfoPtr_isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarStopper>.NativeClassPtr, "isActive");
			CarStopper.NativeFieldInfoPtr_blocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarStopper>.NativeClassPtr, "blocker");
			CarStopper.NativeFieldInfoPtr_Obstacle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarStopper>.NativeClassPtr, "Obstacle");
			CarStopper.NativeFieldInfoPtr_moveTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarStopper>.NativeClassPtr, "moveTime");
			CarStopper.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarStopper>.NativeClassPtr, 100685473);
			CarStopper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarStopper>.NativeClassPtr, 100685474);
		}

		// Token: 0x0600B40C RID: 46092 RVA: 0x002CDB18 File Offset: 0x002CBD18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308794, XrefRangeEnd = 308804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CarStopper.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B40D RID: 46093 RVA: 0x002CDB54 File Offset: 0x002CBD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CarStopper() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarStopper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CarStopper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B40E RID: 46094 RVA: 0x00058445 File Offset: 0x00056645
		public CarStopper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037D0 RID: 14288
		// (get) Token: 0x0600B40F RID: 46095 RVA: 0x002CDB90 File Offset: 0x002CBD90
		// (set) Token: 0x0600B410 RID: 46096 RVA: 0x0005844E File Offset: 0x0005664E
		public unsafe bool isActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_isActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_isActive)) = value;
			}
		}

		// Token: 0x170037D1 RID: 14289
		// (get) Token: 0x0600B411 RID: 46097 RVA: 0x002CDBB8 File Offset: 0x002CBDB8
		// (set) Token: 0x0600B412 RID: 46098 RVA: 0x00058469 File Offset: 0x00056669
		public unsafe Transform blocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_blocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_blocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037D2 RID: 14290
		// (get) Token: 0x0600B413 RID: 46099 RVA: 0x002CDBE8 File Offset: 0x002CBDE8
		// (set) Token: 0x0600B414 RID: 46100 RVA: 0x00058488 File Offset: 0x00056688
		public unsafe NavMeshObstacle Obstacle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_Obstacle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavMeshObstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_Obstacle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037D3 RID: 14291
		// (get) Token: 0x0600B415 RID: 46101 RVA: 0x002CDC18 File Offset: 0x002CBE18
		// (set) Token: 0x0600B416 RID: 46102 RVA: 0x000584A7 File Offset: 0x000566A7
		public unsafe float moveTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_moveTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CarStopper.NativeFieldInfoPtr_moveTime)) = value;
			}
		}

		// Token: 0x04007965 RID: 31077
		private static readonly IntPtr NativeFieldInfoPtr_isActive;

		// Token: 0x04007966 RID: 31078
		private static readonly IntPtr NativeFieldInfoPtr_blocker;

		// Token: 0x04007967 RID: 31079
		private static readonly IntPtr NativeFieldInfoPtr_Obstacle;

		// Token: 0x04007968 RID: 31080
		private static readonly IntPtr NativeFieldInfoPtr_moveTime;

		// Token: 0x04007969 RID: 31081
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400796A RID: 31082
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
