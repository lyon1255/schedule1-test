using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000043 RID: 67
	public class MeleeWeaponTrail : MonoBehaviour
	{
		// Token: 0x0600058C RID: 1420 RVA: 0x000810E4 File Offset: 0x0007F2E4
		// Note: this type is marked as 'beforefieldinit'.
		static MeleeWeaponTrail()
		{
			Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MeleeWeaponTrail");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr);
			MeleeWeaponTrail.NativeFieldInfoPtr__emit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr, "_emit");
			MeleeWeaponTrail.NativeFieldInfoPtr__use = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr, "_use");
			MeleeWeaponTrail.NativeFieldInfoPtr__emitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr, "_emitTime");
			MeleeWeaponTrail.NativeFieldInfoPtr__material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr, "_material");
			MeleeWeaponTrail.NativeFieldInfoPtr__lifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr, "_lifeTime");
			MeleeWeaponTrail.NativeFieldInfoPtr__colors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr, "_colors");
			MeleeWeaponTrail.NativeFieldInfoPtr__sizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr, "_sizes");
			MeleeWeaponTrail.NativeFieldInfoPtr__minVertexDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr, "_minVertexDistance");
			MeleeWeaponTrail.NativeFieldInfoPtr__maxVertexDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr, "_maxVertexDistance");
			MeleeWeaponTrail.NativeFieldInfoPtr__minVertexDistanceSqr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr, "_minVertexDistanceSqr");
			MeleeWeaponTrail.NativeFieldInfoPtr__maxVertexDistanceSqr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr, "_maxVertexDistanceSqr");
			MeleeWeaponTrail.NativeFieldInfoPtr__maxAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr, "_maxAngle");
			MeleeWeaponTrail.NativeFieldInfoPtr__autoDestruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr, "_autoDestruct");
			MeleeWeaponTrail.NativeFieldInfoPtr_subdivisions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr, "subdivisions");
			MeleeWeaponTrail.NativeFieldInfoPtr__base = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr, "_base");
			MeleeWeaponTrail.NativeFieldInfoPtr__tip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr, "_tip");
			MeleeWeaponTrail.NativeFieldInfoPtr__points = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr, "_points");
			MeleeWeaponTrail.NativeFieldInfoPtr__smoothedPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr, "_smoothedPoints");
			MeleeWeaponTrail.NativeFieldInfoPtr__trailObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr, "_trailObject");
			MeleeWeaponTrail.NativeFieldInfoPtr__trailMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr, "_trailMesh");
			MeleeWeaponTrail.NativeFieldInfoPtr__lastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr, "_lastPosition");
			MeleeWeaponTrail.NativeMethodInfoPtr_set_Emit_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr, 100663835);
			MeleeWeaponTrail.NativeMethodInfoPtr_set_Use_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr, 100663836);
			MeleeWeaponTrail.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr, 100663837);
			MeleeWeaponTrail.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr, 100663838);
			MeleeWeaponTrail.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr, 100663839);
			MeleeWeaponTrail.NativeMethodInfoPtr_RemoveOldPoints_Private_Void_List_1_Point_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr, 100663840);
			MeleeWeaponTrail.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr, 100663841);
		}

		// Token: 0x170001DF RID: 479
		// (set) Token: 0x0600058D RID: 1421 RVA: 0x00081344 File Offset: 0x0007F544
		public unsafe bool Emit
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeleeWeaponTrail.NativeMethodInfoPtr_set_Emit_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001E0 RID: 480
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x00081384 File Offset: 0x0007F584
		public unsafe bool Use
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeleeWeaponTrail.NativeMethodInfoPtr_set_Use_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x000813C4 File Offset: 0x0007F5C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75319, XrefRangeEnd = 75371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeleeWeaponTrail.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x000813F8 File Offset: 0x0007F5F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75371, XrefRangeEnd = 75375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeleeWeaponTrail.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x0008142C File Offset: 0x0007F62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75375, XrefRangeEnd = 75524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeleeWeaponTrail.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00081460 File Offset: 0x0007F660
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 75561, RefRangeEnd = 75563, XrefRangeStart = 75524, XrefRangeEnd = 75561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveOldPoints(List<MeleeWeaponTrail.Point> pointList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pointList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeleeWeaponTrail.NativeMethodInfoPtr_RemoveOldPoints_Private_Void_List_1_Point_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x000814A4 File Offset: 0x0007F6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75563, XrefRangeEnd = 75576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MeleeWeaponTrail() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeleeWeaponTrail.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x000053A8 File Offset: 0x000035A8
		public MeleeWeaponTrail(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x000814E0 File Offset: 0x0007F6E0
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x000053B1 File Offset: 0x000035B1
		public unsafe bool _emit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__emit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__emit)) = value;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00081508 File Offset: 0x0007F708
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x000053CC File Offset: 0x000035CC
		public unsafe bool _use
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__use);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__use)) = value;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00081530 File Offset: 0x0007F730
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x000053E7 File Offset: 0x000035E7
		public unsafe float _emitTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__emitTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__emitTime)) = value;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x00081558 File Offset: 0x0007F758
		// (set) Token: 0x0600059C RID: 1436 RVA: 0x00005402 File Offset: 0x00003602
		public unsafe Material _material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x00081588 File Offset: 0x0007F788
		// (set) Token: 0x0600059E RID: 1438 RVA: 0x00005421 File Offset: 0x00003621
		public unsafe float _lifeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__lifeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__lifeTime)) = value;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x000815B0 File Offset: 0x0007F7B0
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x0000543C File Offset: 0x0000363C
		public unsafe Il2CppStructArray<Color> _colors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__colors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__colors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x000815E0 File Offset: 0x0007F7E0
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x0000545B File Offset: 0x0000365B
		public unsafe Il2CppStructArray<float> _sizes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__sizes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__sizes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x00081610 File Offset: 0x0007F810
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x0000547A File Offset: 0x0000367A
		public unsafe float _minVertexDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__minVertexDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__minVertexDistance)) = value;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x00081638 File Offset: 0x0007F838
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x00005495 File Offset: 0x00003695
		public unsafe float _maxVertexDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__maxVertexDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__maxVertexDistance)) = value;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x00081660 File Offset: 0x0007F860
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x000054B0 File Offset: 0x000036B0
		public unsafe float _minVertexDistanceSqr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__minVertexDistanceSqr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__minVertexDistanceSqr)) = value;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x00081688 File Offset: 0x0007F888
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x000054CB File Offset: 0x000036CB
		public unsafe float _maxVertexDistanceSqr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__maxVertexDistanceSqr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__maxVertexDistanceSqr)) = value;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x000816B0 File Offset: 0x0007F8B0
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x000054E6 File Offset: 0x000036E6
		public unsafe float _maxAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__maxAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__maxAngle)) = value;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x000816D8 File Offset: 0x0007F8D8
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x00005501 File Offset: 0x00003701
		public unsafe bool _autoDestruct
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__autoDestruct);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__autoDestruct)) = value;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x00081700 File Offset: 0x0007F900
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x0000551C File Offset: 0x0000371C
		public unsafe int subdivisions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr_subdivisions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr_subdivisions)) = value;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x00081728 File Offset: 0x0007F928
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x00005537 File Offset: 0x00003737
		public unsafe Transform _base
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__base);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__base), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x00081758 File Offset: 0x0007F958
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x00005556 File Offset: 0x00003756
		public unsafe Transform _tip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__tip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__tip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x00081788 File Offset: 0x0007F988
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x00005575 File Offset: 0x00003775
		public unsafe List<MeleeWeaponTrail.Point> _points
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__points);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MeleeWeaponTrail.Point>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__points), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x000817B8 File Offset: 0x0007F9B8
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x00005594 File Offset: 0x00003794
		public unsafe List<MeleeWeaponTrail.Point> _smoothedPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__smoothedPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MeleeWeaponTrail.Point>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__smoothedPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x000817E8 File Offset: 0x0007F9E8
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x000055B3 File Offset: 0x000037B3
		public unsafe GameObject _trailObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__trailObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__trailObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x00081818 File Offset: 0x0007FA18
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x000055D2 File Offset: 0x000037D2
		public unsafe Mesh _trailMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__trailMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__trailMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x00081848 File Offset: 0x0007FA48
		// (set) Token: 0x060005BE RID: 1470 RVA: 0x000055F1 File Offset: 0x000037F1
		public unsafe Vector3 _lastPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__lastPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.NativeFieldInfoPtr__lastPosition)) = value;
			}
		}

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeFieldInfoPtr__emit;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeFieldInfoPtr__use;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeFieldInfoPtr__emitTime;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeFieldInfoPtr__material;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeFieldInfoPtr__lifeTime;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeFieldInfoPtr__colors;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeFieldInfoPtr__sizes;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeFieldInfoPtr__minVertexDistance;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeFieldInfoPtr__maxVertexDistance;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeFieldInfoPtr__minVertexDistanceSqr;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeFieldInfoPtr__maxVertexDistanceSqr;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeFieldInfoPtr__maxAngle;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeFieldInfoPtr__autoDestruct;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeFieldInfoPtr_subdivisions;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeFieldInfoPtr__base;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeFieldInfoPtr__tip;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeFieldInfoPtr__points;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeFieldInfoPtr__smoothedPoints;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeFieldInfoPtr__trailObject;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeFieldInfoPtr__trailMesh;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeFieldInfoPtr__lastPosition;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeMethodInfoPtr_set_Emit_Public_set_Void_Boolean_0;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeMethodInfoPtr_set_Use_Public_set_Void_Boolean_0;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeMethodInfoPtr_RemoveOldPoints_Private_Void_List_1_Point_0;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007C0 RID: 1984
		[Serializable]
		public class Point : Il2CppSystem.Object
		{
			// Token: 0x0600BAA9 RID: 47785 RVA: 0x002E4214 File Offset: 0x002E2414
			// Note: this type is marked as 'beforefieldinit'.
			static Point()
			{
				Il2CppClassPointerStore<MeleeWeaponTrail.Point>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeleeWeaponTrail>.NativeClassPtr, "Point");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeleeWeaponTrail.Point>.NativeClassPtr);
				MeleeWeaponTrail.Point.NativeFieldInfoPtr_timeCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeleeWeaponTrail.Point>.NativeClassPtr, "timeCreated");
				MeleeWeaponTrail.Point.NativeFieldInfoPtr_basePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeleeWeaponTrail.Point>.NativeClassPtr, "basePosition");
				MeleeWeaponTrail.Point.NativeFieldInfoPtr_tipPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeleeWeaponTrail.Point>.NativeClassPtr, "tipPosition");
				MeleeWeaponTrail.Point.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeleeWeaponTrail.Point>.NativeClassPtr, 100663842);
			}

			// Token: 0x0600BAAA RID: 47786 RVA: 0x002E4290 File Offset: 0x002E2490
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Point() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeleeWeaponTrail.Point>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeleeWeaponTrail.Point.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BAAB RID: 47787 RVA: 0x0005B572 File Offset: 0x00059772
			public Point(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170039A6 RID: 14758
			// (get) Token: 0x0600BAAC RID: 47788 RVA: 0x002E42CC File Offset: 0x002E24CC
			// (set) Token: 0x0600BAAD RID: 47789 RVA: 0x0005B57B File Offset: 0x0005977B
			public unsafe float timeCreated
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.Point.NativeFieldInfoPtr_timeCreated);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.Point.NativeFieldInfoPtr_timeCreated)) = value;
				}
			}

			// Token: 0x170039A7 RID: 14759
			// (get) Token: 0x0600BAAE RID: 47790 RVA: 0x002E42F4 File Offset: 0x002E24F4
			// (set) Token: 0x0600BAAF RID: 47791 RVA: 0x0005B596 File Offset: 0x00059796
			public unsafe Vector3 basePosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.Point.NativeFieldInfoPtr_basePosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.Point.NativeFieldInfoPtr_basePosition)) = value;
				}
			}

			// Token: 0x170039A8 RID: 14760
			// (get) Token: 0x0600BAB0 RID: 47792 RVA: 0x002E431C File Offset: 0x002E251C
			// (set) Token: 0x0600BAB1 RID: 47793 RVA: 0x0005B5B1 File Offset: 0x000597B1
			public unsafe Vector3 tipPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.Point.NativeFieldInfoPtr_tipPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeleeWeaponTrail.Point.NativeFieldInfoPtr_tipPosition)) = value;
				}
			}

			// Token: 0x04007DE9 RID: 32233
			private static readonly IntPtr NativeFieldInfoPtr_timeCreated;

			// Token: 0x04007DEA RID: 32234
			private static readonly IntPtr NativeFieldInfoPtr_basePosition;

			// Token: 0x04007DEB RID: 32235
			private static readonly IntPtr NativeFieldInfoPtr_tipPosition;

			// Token: 0x04007DEC RID: 32236
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
