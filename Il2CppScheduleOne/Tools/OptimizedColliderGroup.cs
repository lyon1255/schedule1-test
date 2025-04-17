using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000542 RID: 1346
	public class OptimizedColliderGroup : MonoBehaviour
	{
		// Token: 0x0600773A RID: 30522 RVA: 0x00205778 File Offset: 0x00203978
		// Note: this type is marked as 'beforefieldinit'.
		static OptimizedColliderGroup()
		{
			Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "OptimizedColliderGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr);
			OptimizedColliderGroup.NativeFieldInfoPtr_UPDATE_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, "UPDATE_DISTANCE");
			OptimizedColliderGroup.NativeFieldInfoPtr_Colliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, "Colliders");
			OptimizedColliderGroup.NativeFieldInfoPtr_ColliderEnableMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, "ColliderEnableMaxDistance");
			OptimizedColliderGroup.NativeFieldInfoPtr_sqrColliderEnableMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, "sqrColliderEnableMaxDistance");
			OptimizedColliderGroup.NativeFieldInfoPtr_collidersEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, "collidersEnabled");
			OptimizedColliderGroup.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678318);
			OptimizedColliderGroup.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678319);
			OptimizedColliderGroup.NativeMethodInfoPtr_RegisterEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678320);
			OptimizedColliderGroup.NativeMethodInfoPtr_GetColliders_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678321);
			OptimizedColliderGroup.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678322);
			OptimizedColliderGroup.NativeMethodInfoPtr_Refresh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678323);
			OptimizedColliderGroup.NativeMethodInfoPtr_SetCollidersEnabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678324);
			OptimizedColliderGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr, 100678325);
		}

		// Token: 0x0600773B RID: 30523 RVA: 0x002058AC File Offset: 0x00203AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231420, XrefRangeEnd = 231444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600773C RID: 30524 RVA: 0x002058E0 File Offset: 0x00203AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231444, XrefRangeEnd = 231458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600773D RID: 30525 RVA: 0x00205914 File Offset: 0x00203B14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 231489, RefRangeEnd = 231490, XrefRangeStart = 231458, XrefRangeEnd = 231489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr_RegisterEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600773E RID: 30526 RVA: 0x00205948 File Offset: 0x00203B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231490, XrefRangeEnd = 231494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetColliders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr_GetColliders_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600773F RID: 30527 RVA: 0x0020597C File Offset: 0x00203B7C
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007740 RID: 30528 RVA: 0x002059B0 File Offset: 0x00203BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231494, XrefRangeEnd = 231520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr_Refresh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007741 RID: 30529 RVA: 0x002059E4 File Offset: 0x00203BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231520, XrefRangeEnd = 231526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCollidersEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr_SetCollidersEnabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007742 RID: 30530 RVA: 0x00205A24 File Offset: 0x00203C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231526, XrefRangeEnd = 231527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptimizedColliderGroup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptimizedColliderGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedColliderGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007743 RID: 30531 RVA: 0x0003878D File Offset: 0x0003698D
		public OptimizedColliderGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700240E RID: 9230
		// (get) Token: 0x06007744 RID: 30532 RVA: 0x00205A60 File Offset: 0x00203C60
		// (set) Token: 0x06007745 RID: 30533 RVA: 0x00038796 File Offset: 0x00036996
		public unsafe static int UPDATE_DISTANCE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(OptimizedColliderGroup.NativeFieldInfoPtr_UPDATE_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OptimizedColliderGroup.NativeFieldInfoPtr_UPDATE_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x1700240F RID: 9231
		// (get) Token: 0x06007746 RID: 30534 RVA: 0x00205A7C File Offset: 0x00203C7C
		// (set) Token: 0x06007747 RID: 30535 RVA: 0x000387A4 File Offset: 0x000369A4
		public unsafe Il2CppReferenceArray<Collider> Colliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_Colliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_Colliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002410 RID: 9232
		// (get) Token: 0x06007748 RID: 30536 RVA: 0x00205AAC File Offset: 0x00203CAC
		// (set) Token: 0x06007749 RID: 30537 RVA: 0x000387C3 File Offset: 0x000369C3
		public unsafe float ColliderEnableMaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_ColliderEnableMaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_ColliderEnableMaxDistance)) = value;
			}
		}

		// Token: 0x17002411 RID: 9233
		// (get) Token: 0x0600774A RID: 30538 RVA: 0x00205AD4 File Offset: 0x00203CD4
		// (set) Token: 0x0600774B RID: 30539 RVA: 0x000387DE File Offset: 0x000369DE
		public unsafe float sqrColliderEnableMaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_sqrColliderEnableMaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_sqrColliderEnableMaxDistance)) = value;
			}
		}

		// Token: 0x17002412 RID: 9234
		// (get) Token: 0x0600774C RID: 30540 RVA: 0x00205AFC File Offset: 0x00203CFC
		// (set) Token: 0x0600774D RID: 30541 RVA: 0x000387F9 File Offset: 0x000369F9
		public unsafe bool collidersEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_collidersEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedColliderGroup.NativeFieldInfoPtr_collidersEnabled)) = value;
			}
		}

		// Token: 0x04005160 RID: 20832
		private static readonly IntPtr NativeFieldInfoPtr_UPDATE_DISTANCE;

		// Token: 0x04005161 RID: 20833
		private static readonly IntPtr NativeFieldInfoPtr_Colliders;

		// Token: 0x04005162 RID: 20834
		private static readonly IntPtr NativeFieldInfoPtr_ColliderEnableMaxDistance;

		// Token: 0x04005163 RID: 20835
		private static readonly IntPtr NativeFieldInfoPtr_sqrColliderEnableMaxDistance;

		// Token: 0x04005164 RID: 20836
		private static readonly IntPtr NativeFieldInfoPtr_collidersEnabled;

		// Token: 0x04005165 RID: 20837
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04005166 RID: 20838
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04005167 RID: 20839
		private static readonly IntPtr NativeMethodInfoPtr_RegisterEvent_Private_Void_0;

		// Token: 0x04005168 RID: 20840
		private static readonly IntPtr NativeMethodInfoPtr_GetColliders_Public_Void_0;

		// Token: 0x04005169 RID: 20841
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400516A RID: 20842
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_0;

		// Token: 0x0400516B RID: 20843
		private static readonly IntPtr NativeMethodInfoPtr_SetCollidersEnabled_Private_Void_Boolean_0;

		// Token: 0x0400516C RID: 20844
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
