using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x02000563 RID: 1379
	public class FunctionalJar : FunctionalPackaging
	{
		// Token: 0x060078F8 RID: 30968 RVA: 0x0020A6BC File Offset: 0x002088BC
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionalJar()
		{
			Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "FunctionalJar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr);
			FunctionalJar.NativeFieldInfoPtr__HoveredCursor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "<HoveredCursor>k__BackingField");
			FunctionalJar.NativeFieldInfoPtr_Lid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "Lid");
			FunctionalJar.NativeFieldInfoPtr_LidStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "LidStartPoint");
			FunctionalJar.NativeFieldInfoPtr_LidSensor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "LidSensor");
			FunctionalJar.NativeFieldInfoPtr_LidCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "LidCollider");
			FunctionalJar.NativeFieldInfoPtr_FullyPackedBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "FullyPackedBlocker");
			FunctionalJar.NativeFieldInfoPtr_LidObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "LidObject");
			FunctionalJar.NativeFieldInfoPtr_lidPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, "lidPosition");
			FunctionalJar.NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_get_ECursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678468);
			FunctionalJar.NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_set_Void_ECursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678469);
			FunctionalJar.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_PackagingStation_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678470);
			FunctionalJar.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678471);
			FunctionalJar.NativeMethodInfoPtr_EnableSealing_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678472);
			FunctionalJar.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678473);
			FunctionalJar.NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678474);
			FunctionalJar.NativeMethodInfoPtr_Seal_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678475);
			FunctionalJar.NativeMethodInfoPtr_FullyPacked_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678476);
			FunctionalJar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr, 100678477);
		}

		// Token: 0x1700249B RID: 9371
		// (get) Token: 0x060078F9 RID: 30969 RVA: 0x0020A854 File Offset: 0x00208A54
		// (set) Token: 0x060078FA RID: 30970 RVA: 0x0020A89C File Offset: 0x00208A9C
		public unsafe override CursorManager.ECursorType HoveredCursor
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 60909, RefRangeEnd = 60949, XrefRangeStart = 60909, XrefRangeEnd = 60949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_get_ECursorType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_set_Void_ECursorType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060078FB RID: 30971 RVA: 0x0020A8E8 File Offset: 0x00208AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232630, XrefRangeEnd = 232658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(PackagingStation _station, Transform alignment, bool align = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_station);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(alignment);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref align;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_PackagingStation_Transform_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078FC RID: 30972 RVA: 0x0020A958 File Offset: 0x00208B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232658, XrefRangeEnd = 232667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078FD RID: 30973 RVA: 0x0020A994 File Offset: 0x00208B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232667, XrefRangeEnd = 232671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void EnableSealing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_EnableSealing_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078FE RID: 30974 RVA: 0x0020A9D0 File Offset: 0x00208BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232671, XrefRangeEnd = 232672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078FF RID: 30975 RVA: 0x0020AA0C File Offset: 0x00208C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232672, XrefRangeEnd = 232683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_Void_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007900 RID: 30976 RVA: 0x0020AA5C File Offset: 0x00208C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232683, XrefRangeEnd = 232700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Seal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_Seal_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007901 RID: 30977 RVA: 0x0020AA98 File Offset: 0x00208C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232700, XrefRangeEnd = 232703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FullyPacked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FunctionalJar.NativeMethodInfoPtr_FullyPacked_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007902 RID: 30978 RVA: 0x0020AAD4 File Offset: 0x00208CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232703, XrefRangeEnd = 232706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionalJar() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionalJar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalJar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007903 RID: 30979 RVA: 0x000396B1 File Offset: 0x000378B1
		public FunctionalJar(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002493 RID: 9363
		// (get) Token: 0x06007904 RID: 30980 RVA: 0x0020AB10 File Offset: 0x00208D10
		// (set) Token: 0x06007905 RID: 30981 RVA: 0x000396BA File Offset: 0x000378BA
		public new unsafe CursorManager.ECursorType _HoveredCursor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr__HoveredCursor_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr__HoveredCursor_k__BackingField)) = value;
			}
		}

		// Token: 0x17002494 RID: 9364
		// (get) Token: 0x06007906 RID: 30982 RVA: 0x0020AB38 File Offset: 0x00208D38
		// (set) Token: 0x06007907 RID: 30983 RVA: 0x000396D5 File Offset: 0x000378D5
		public unsafe Draggable Lid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_Lid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_Lid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002495 RID: 9365
		// (get) Token: 0x06007908 RID: 30984 RVA: 0x0020AB68 File Offset: 0x00208D68
		// (set) Token: 0x06007909 RID: 30985 RVA: 0x000396F4 File Offset: 0x000378F4
		public unsafe Transform LidStartPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidStartPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidStartPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002496 RID: 9366
		// (get) Token: 0x0600790A RID: 30986 RVA: 0x0020AB98 File Offset: 0x00208D98
		// (set) Token: 0x0600790B RID: 30987 RVA: 0x00039713 File Offset: 0x00037913
		public unsafe Collider LidSensor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidSensor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidSensor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002497 RID: 9367
		// (get) Token: 0x0600790C RID: 30988 RVA: 0x0020ABC8 File Offset: 0x00208DC8
		// (set) Token: 0x0600790D RID: 30989 RVA: 0x00039732 File Offset: 0x00037932
		public unsafe Collider LidCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002498 RID: 9368
		// (get) Token: 0x0600790E RID: 30990 RVA: 0x0020ABF8 File Offset: 0x00208DF8
		// (set) Token: 0x0600790F RID: 30991 RVA: 0x00039751 File Offset: 0x00037951
		public unsafe GameObject FullyPackedBlocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_FullyPackedBlocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_FullyPackedBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002499 RID: 9369
		// (get) Token: 0x06007910 RID: 30992 RVA: 0x0020AC28 File Offset: 0x00208E28
		// (set) Token: 0x06007911 RID: 30993 RVA: 0x00039770 File Offset: 0x00037970
		public unsafe GameObject LidObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_LidObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700249A RID: 9370
		// (get) Token: 0x06007912 RID: 30994 RVA: 0x0020AC58 File Offset: 0x00208E58
		// (set) Token: 0x06007913 RID: 30995 RVA: 0x0003978F File Offset: 0x0003798F
		public unsafe Vector3 lidPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_lidPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionalJar.NativeFieldInfoPtr_lidPosition)) = value;
			}
		}

		// Token: 0x0400525F RID: 21087
		private static readonly IntPtr NativeFieldInfoPtr__HoveredCursor_k__BackingField;

		// Token: 0x04005260 RID: 21088
		private static readonly IntPtr NativeFieldInfoPtr_Lid;

		// Token: 0x04005261 RID: 21089
		private static readonly IntPtr NativeFieldInfoPtr_LidStartPoint;

		// Token: 0x04005262 RID: 21090
		private static readonly IntPtr NativeFieldInfoPtr_LidSensor;

		// Token: 0x04005263 RID: 21091
		private static readonly IntPtr NativeFieldInfoPtr_LidCollider;

		// Token: 0x04005264 RID: 21092
		private static readonly IntPtr NativeFieldInfoPtr_FullyPackedBlocker;

		// Token: 0x04005265 RID: 21093
		private static readonly IntPtr NativeFieldInfoPtr_LidObject;

		// Token: 0x04005266 RID: 21094
		private static readonly IntPtr NativeFieldInfoPtr_lidPosition;

		// Token: 0x04005267 RID: 21095
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredCursor_Public_Virtual_get_ECursorType_0;

		// Token: 0x04005268 RID: 21096
		private static readonly IntPtr NativeMethodInfoPtr_set_HoveredCursor_Protected_Virtual_set_Void_ECursorType_0;

		// Token: 0x04005269 RID: 21097
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_PackagingStation_Transform_Boolean_0;

		// Token: 0x0400526A RID: 21098
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0;

		// Token: 0x0400526B RID: 21099
		private static readonly IntPtr NativeMethodInfoPtr_EnableSealing_Protected_Virtual_Void_0;

		// Token: 0x0400526C RID: 21100
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400526D RID: 21101
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_Void_Collider_0;

		// Token: 0x0400526E RID: 21102
		private static readonly IntPtr NativeMethodInfoPtr_Seal_Public_Virtual_Void_0;

		// Token: 0x0400526F RID: 21103
		private static readonly IntPtr NativeMethodInfoPtr_FullyPacked_Protected_Virtual_Void_0;

		// Token: 0x04005270 RID: 21104
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
