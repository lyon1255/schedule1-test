using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppScheduleOne.StationFramework;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200073D RID: 1853
	public class Beaker : StationItem
	{
		// Token: 0x0600AAF0 RID: 43760 RVA: 0x002AB14C File Offset: 0x002A934C
		// Note: this type is marked as 'beforefieldinit'.
		static Beaker()
		{
			Il2CppClassPointerStore<Beaker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Beaker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Beaker>.NativeClassPtr);
			Beaker.NativeFieldInfoPtr_ClampAngle_MaxLiquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "ClampAngle_MaxLiquid");
			Beaker.NativeFieldInfoPtr_ClampAngle_MinLiquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "ClampAngle_MinLiquid");
			Beaker.NativeFieldInfoPtr_AngleToPour_MaxLiquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "AngleToPour_MaxLiquid");
			Beaker.NativeFieldInfoPtr_AngleToPour_MinLiquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "AngleToPour_MinLiquid");
			Beaker.NativeFieldInfoPtr_Draggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "Draggable");
			Beaker.NativeFieldInfoPtr_Constraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "Constraint");
			Beaker.NativeFieldInfoPtr_ConcaveCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "ConcaveCollider");
			Beaker.NativeFieldInfoPtr_ConvexCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "ConvexCollider");
			Beaker.NativeFieldInfoPtr_CenterOfMass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "CenterOfMass");
			Beaker.NativeFieldInfoPtr_Joint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "Joint");
			Beaker.NativeFieldInfoPtr_Anchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "Anchor");
			Beaker.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "Container");
			Beaker.NativeFieldInfoPtr_Fillable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "Fillable");
			Beaker.NativeFieldInfoPtr_Pourable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "Pourable");
			Beaker.NativeFieldInfoPtr_FilterPaper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Beaker>.NativeClassPtr, "FilterPaper");
			Beaker.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Beaker>.NativeClassPtr, 100684286);
			Beaker.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Beaker>.NativeClassPtr, 100684287);
			Beaker.NativeMethodInfoPtr_SetStatic_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Beaker>.NativeClassPtr, 100684288);
			Beaker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Beaker>.NativeClassPtr, 100684289);
		}

		// Token: 0x0600AAF1 RID: 43761 RVA: 0x002AB2F8 File Offset: 0x002A94F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296828, XrefRangeEnd = 296833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Beaker.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AAF2 RID: 43762 RVA: 0x002AB32C File Offset: 0x002A952C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296833, XrefRangeEnd = 296838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Beaker.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AAF3 RID: 43763 RVA: 0x002AB360 File Offset: 0x002A9560
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296842, RefRangeEnd = 296843, XrefRangeStart = 296838, XrefRangeEnd = 296842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStatic(bool stat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref stat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Beaker.NativeMethodInfoPtr_SetStatic_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AAF4 RID: 43764 RVA: 0x002AB3A0 File Offset: 0x002A95A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296843, XrefRangeEnd = 296844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Beaker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Beaker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Beaker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AAF5 RID: 43765 RVA: 0x00054127 File Offset: 0x00052327
		public Beaker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170034DC RID: 13532
		// (get) Token: 0x0600AAF6 RID: 43766 RVA: 0x002AB3DC File Offset: 0x002A95DC
		// (set) Token: 0x0600AAF7 RID: 43767 RVA: 0x00054130 File Offset: 0x00052330
		public unsafe float ClampAngle_MaxLiquid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ClampAngle_MaxLiquid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ClampAngle_MaxLiquid)) = value;
			}
		}

		// Token: 0x170034DD RID: 13533
		// (get) Token: 0x0600AAF8 RID: 43768 RVA: 0x002AB404 File Offset: 0x002A9604
		// (set) Token: 0x0600AAF9 RID: 43769 RVA: 0x0005414B File Offset: 0x0005234B
		public unsafe float ClampAngle_MinLiquid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ClampAngle_MinLiquid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ClampAngle_MinLiquid)) = value;
			}
		}

		// Token: 0x170034DE RID: 13534
		// (get) Token: 0x0600AAFA RID: 43770 RVA: 0x002AB42C File Offset: 0x002A962C
		// (set) Token: 0x0600AAFB RID: 43771 RVA: 0x00054166 File Offset: 0x00052366
		public unsafe float AngleToPour_MaxLiquid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_AngleToPour_MaxLiquid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_AngleToPour_MaxLiquid)) = value;
			}
		}

		// Token: 0x170034DF RID: 13535
		// (get) Token: 0x0600AAFC RID: 43772 RVA: 0x002AB454 File Offset: 0x002A9654
		// (set) Token: 0x0600AAFD RID: 43773 RVA: 0x00054181 File Offset: 0x00052381
		public unsafe float AngleToPour_MinLiquid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_AngleToPour_MinLiquid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_AngleToPour_MinLiquid)) = value;
			}
		}

		// Token: 0x170034E0 RID: 13536
		// (get) Token: 0x0600AAFE RID: 43774 RVA: 0x002AB47C File Offset: 0x002A967C
		// (set) Token: 0x0600AAFF RID: 43775 RVA: 0x0005419C File Offset: 0x0005239C
		public unsafe Draggable Draggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Draggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Draggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034E1 RID: 13537
		// (get) Token: 0x0600AB00 RID: 43776 RVA: 0x002AB4AC File Offset: 0x002A96AC
		// (set) Token: 0x0600AB01 RID: 43777 RVA: 0x000541BB File Offset: 0x000523BB
		public unsafe DraggableConstraint Constraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Constraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DraggableConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Constraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034E2 RID: 13538
		// (get) Token: 0x0600AB02 RID: 43778 RVA: 0x002AB4DC File Offset: 0x002A96DC
		// (set) Token: 0x0600AB03 RID: 43779 RVA: 0x000541DA File Offset: 0x000523DA
		public unsafe Collider ConcaveCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ConcaveCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ConcaveCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034E3 RID: 13539
		// (get) Token: 0x0600AB04 RID: 43780 RVA: 0x002AB50C File Offset: 0x002A970C
		// (set) Token: 0x0600AB05 RID: 43781 RVA: 0x000541F9 File Offset: 0x000523F9
		public unsafe Collider ConvexCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ConvexCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_ConvexCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034E4 RID: 13540
		// (get) Token: 0x0600AB06 RID: 43782 RVA: 0x002AB53C File Offset: 0x002A973C
		// (set) Token: 0x0600AB07 RID: 43783 RVA: 0x00054218 File Offset: 0x00052418
		public unsafe Transform CenterOfMass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_CenterOfMass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_CenterOfMass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034E5 RID: 13541
		// (get) Token: 0x0600AB08 RID: 43784 RVA: 0x002AB56C File Offset: 0x002A976C
		// (set) Token: 0x0600AB09 RID: 43785 RVA: 0x00054237 File Offset: 0x00052437
		public unsafe ConfigurableJoint Joint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Joint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurableJoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Joint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034E6 RID: 13542
		// (get) Token: 0x0600AB0A RID: 43786 RVA: 0x002AB59C File Offset: 0x002A979C
		// (set) Token: 0x0600AB0B RID: 43787 RVA: 0x00054256 File Offset: 0x00052456
		public unsafe Rigidbody Anchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Anchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Anchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034E7 RID: 13543
		// (get) Token: 0x0600AB0C RID: 43788 RVA: 0x002AB5CC File Offset: 0x002A97CC
		// (set) Token: 0x0600AB0D RID: 43789 RVA: 0x00054275 File Offset: 0x00052475
		public unsafe LiquidContainer Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034E8 RID: 13544
		// (get) Token: 0x0600AB0E RID: 43790 RVA: 0x002AB5FC File Offset: 0x002A97FC
		// (set) Token: 0x0600AB0F RID: 43791 RVA: 0x00054294 File Offset: 0x00052494
		public unsafe Fillable Fillable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Fillable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Fillable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Fillable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034E9 RID: 13545
		// (get) Token: 0x0600AB10 RID: 43792 RVA: 0x002AB62C File Offset: 0x002A982C
		// (set) Token: 0x0600AB11 RID: 43793 RVA: 0x000542B3 File Offset: 0x000524B3
		public unsafe PourableModule Pourable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Pourable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PourableModule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_Pourable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170034EA RID: 13546
		// (get) Token: 0x0600AB12 RID: 43794 RVA: 0x002AB65C File Offset: 0x002A985C
		// (set) Token: 0x0600AB13 RID: 43795 RVA: 0x000542D2 File Offset: 0x000524D2
		public unsafe GameObject FilterPaper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_FilterPaper);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Beaker.NativeFieldInfoPtr_FilterPaper), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040072DE RID: 29406
		private static readonly IntPtr NativeFieldInfoPtr_ClampAngle_MaxLiquid;

		// Token: 0x040072DF RID: 29407
		private static readonly IntPtr NativeFieldInfoPtr_ClampAngle_MinLiquid;

		// Token: 0x040072E0 RID: 29408
		private static readonly IntPtr NativeFieldInfoPtr_AngleToPour_MaxLiquid;

		// Token: 0x040072E1 RID: 29409
		private static readonly IntPtr NativeFieldInfoPtr_AngleToPour_MinLiquid;

		// Token: 0x040072E2 RID: 29410
		private static readonly IntPtr NativeFieldInfoPtr_Draggable;

		// Token: 0x040072E3 RID: 29411
		private static readonly IntPtr NativeFieldInfoPtr_Constraint;

		// Token: 0x040072E4 RID: 29412
		private static readonly IntPtr NativeFieldInfoPtr_ConcaveCollider;

		// Token: 0x040072E5 RID: 29413
		private static readonly IntPtr NativeFieldInfoPtr_ConvexCollider;

		// Token: 0x040072E6 RID: 29414
		private static readonly IntPtr NativeFieldInfoPtr_CenterOfMass;

		// Token: 0x040072E7 RID: 29415
		private static readonly IntPtr NativeFieldInfoPtr_Joint;

		// Token: 0x040072E8 RID: 29416
		private static readonly IntPtr NativeFieldInfoPtr_Anchor;

		// Token: 0x040072E9 RID: 29417
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040072EA RID: 29418
		private static readonly IntPtr NativeFieldInfoPtr_Fillable;

		// Token: 0x040072EB RID: 29419
		private static readonly IntPtr NativeFieldInfoPtr_Pourable;

		// Token: 0x040072EC RID: 29420
		private static readonly IntPtr NativeFieldInfoPtr_FilterPaper;

		// Token: 0x040072ED RID: 29421
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040072EE RID: 29422
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040072EF RID: 29423
		private static readonly IntPtr NativeMethodInfoPtr_SetStatic_Public_Void_Boolean_0;

		// Token: 0x040072F0 RID: 29424
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
