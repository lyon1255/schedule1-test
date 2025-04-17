using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppStylizedGrassDemo
{
	// Token: 0x020000C4 RID: 196
	public class OrbitCamera : MonoBehaviour
	{
		// Token: 0x06000E91 RID: 3729 RVA: 0x0009EF24 File Offset: 0x0009D124
		// Note: this type is marked as 'beforefieldinit'.
		static OrbitCamera()
		{
			Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "StylizedGrassDemo", "OrbitCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr);
			OrbitCamera.NativeFieldInfoPtr_pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "pivot");
			OrbitCamera.NativeFieldInfoPtr_enableMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "enableMouse");
			OrbitCamera.NativeFieldInfoPtr_idleRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "idleRotationSpeed");
			OrbitCamera.NativeFieldInfoPtr_lookSmoothSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "lookSmoothSpeed");
			OrbitCamera.NativeFieldInfoPtr_moveSmoothSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "moveSmoothSpeed");
			OrbitCamera.NativeFieldInfoPtr_scrollSmoothSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "scrollSmoothSpeed");
			OrbitCamera.NativeFieldInfoPtr_cam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "cam");
			OrbitCamera.NativeFieldInfoPtr_cameraRotSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "cameraRotSide");
			OrbitCamera.NativeFieldInfoPtr_cameraRotUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "cameraRotUp");
			OrbitCamera.NativeFieldInfoPtr_cameraRotSideCur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "cameraRotSideCur");
			OrbitCamera.NativeFieldInfoPtr_cameraRotUpCur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "cameraRotUpCur");
			OrbitCamera.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "distance");
			OrbitCamera.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100665048);
			OrbitCamera.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100665049);
			OrbitCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100665050);
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x0009F080 File Offset: 0x0009D280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85806, XrefRangeEnd = 85818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x0009F0B4 File Offset: 0x0009D2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85818, XrefRangeEnd = 85864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x0009F0E8 File Offset: 0x0009D2E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85864, XrefRangeEnd = 85865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OrbitCamera() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x000091B1 File Offset: 0x000073B1
		public OrbitCamera(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000E96 RID: 3734 RVA: 0x0009F124 File Offset: 0x0009D324
		// (set) Token: 0x06000E97 RID: 3735 RVA: 0x000091BA File Offset: 0x000073BA
		public unsafe Transform pivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_pivot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_pivot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000E98 RID: 3736 RVA: 0x0009F154 File Offset: 0x0009D354
		// (set) Token: 0x06000E99 RID: 3737 RVA: 0x000091D9 File Offset: 0x000073D9
		public unsafe bool enableMouse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_enableMouse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_enableMouse)) = value;
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000E9A RID: 3738 RVA: 0x0009F17C File Offset: 0x0009D37C
		// (set) Token: 0x06000E9B RID: 3739 RVA: 0x000091F4 File Offset: 0x000073F4
		public unsafe float idleRotationSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_idleRotationSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_idleRotationSpeed)) = value;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000E9C RID: 3740 RVA: 0x0009F1A4 File Offset: 0x0009D3A4
		// (set) Token: 0x06000E9D RID: 3741 RVA: 0x0000920F File Offset: 0x0000740F
		public unsafe float lookSmoothSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_lookSmoothSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_lookSmoothSpeed)) = value;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000E9E RID: 3742 RVA: 0x0009F1CC File Offset: 0x0009D3CC
		// (set) Token: 0x06000E9F RID: 3743 RVA: 0x0000922A File Offset: 0x0000742A
		public unsafe float moveSmoothSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_moveSmoothSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_moveSmoothSpeed)) = value;
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x0009F1F4 File Offset: 0x0009D3F4
		// (set) Token: 0x06000EA1 RID: 3745 RVA: 0x00009245 File Offset: 0x00007445
		public unsafe float scrollSmoothSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_scrollSmoothSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_scrollSmoothSpeed)) = value;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x0009F21C File Offset: 0x0009D41C
		// (set) Token: 0x06000EA3 RID: 3747 RVA: 0x00009260 File Offset: 0x00007460
		public unsafe Transform cam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_cam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_cam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000EA4 RID: 3748 RVA: 0x0009F24C File Offset: 0x0009D44C
		// (set) Token: 0x06000EA5 RID: 3749 RVA: 0x0000927F File Offset: 0x0000747F
		public unsafe float cameraRotSide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_cameraRotSide);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_cameraRotSide)) = value;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000EA6 RID: 3750 RVA: 0x0009F274 File Offset: 0x0009D474
		// (set) Token: 0x06000EA7 RID: 3751 RVA: 0x0000929A File Offset: 0x0000749A
		public unsafe float cameraRotUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_cameraRotUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_cameraRotUp)) = value;
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000EA8 RID: 3752 RVA: 0x0009F29C File Offset: 0x0009D49C
		// (set) Token: 0x06000EA9 RID: 3753 RVA: 0x000092B5 File Offset: 0x000074B5
		public unsafe float cameraRotSideCur
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_cameraRotSideCur);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_cameraRotSideCur)) = value;
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000EAA RID: 3754 RVA: 0x0009F2C4 File Offset: 0x0009D4C4
		// (set) Token: 0x06000EAB RID: 3755 RVA: 0x000092D0 File Offset: 0x000074D0
		public unsafe float cameraRotUpCur
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_cameraRotUpCur);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_cameraRotUpCur)) = value;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000EAC RID: 3756 RVA: 0x0009F2EC File Offset: 0x0009D4EC
		// (set) Token: 0x06000EAD RID: 3757 RVA: 0x000092EB File Offset: 0x000074EB
		public unsafe float distance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_distance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_distance)) = value;
			}
		}

		// Token: 0x040009C0 RID: 2496
		private static readonly IntPtr NativeFieldInfoPtr_pivot;

		// Token: 0x040009C1 RID: 2497
		private static readonly IntPtr NativeFieldInfoPtr_enableMouse;

		// Token: 0x040009C2 RID: 2498
		private static readonly IntPtr NativeFieldInfoPtr_idleRotationSpeed;

		// Token: 0x040009C3 RID: 2499
		private static readonly IntPtr NativeFieldInfoPtr_lookSmoothSpeed;

		// Token: 0x040009C4 RID: 2500
		private static readonly IntPtr NativeFieldInfoPtr_moveSmoothSpeed;

		// Token: 0x040009C5 RID: 2501
		private static readonly IntPtr NativeFieldInfoPtr_scrollSmoothSpeed;

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeFieldInfoPtr_cam;

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeFieldInfoPtr_cameraRotSide;

		// Token: 0x040009C8 RID: 2504
		private static readonly IntPtr NativeFieldInfoPtr_cameraRotUp;

		// Token: 0x040009C9 RID: 2505
		private static readonly IntPtr NativeFieldInfoPtr_cameraRotSideCur;

		// Token: 0x040009CA RID: 2506
		private static readonly IntPtr NativeFieldInfoPtr_cameraRotUpCur;

		// Token: 0x040009CB RID: 2507
		private static readonly IntPtr NativeFieldInfoPtr_distance;

		// Token: 0x040009CC RID: 2508
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040009CD RID: 2509
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040009CE RID: 2510
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
