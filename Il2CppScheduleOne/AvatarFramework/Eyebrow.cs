using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x020005F5 RID: 1525
	public class Eyebrow : MonoBehaviour
	{
		// Token: 0x0600865A RID: 34394 RVA: 0x00238C08 File Offset: 0x00236E08
		// Note: this type is marked as 'beforefieldinit'.
		static Eyebrow()
		{
			Il2CppClassPointerStore<Eyebrow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "Eyebrow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr);
			Eyebrow.NativeFieldInfoPtr_eyebrowHeightMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "eyebrowHeightMultiplier");
			Eyebrow.NativeFieldInfoPtr_EyebrowDefaultScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "EyebrowDefaultScale");
			Eyebrow.NativeFieldInfoPtr_EyebrowDefaultLocalPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "EyebrowDefaultLocalPos");
			Eyebrow.NativeFieldInfoPtr_Side = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "Side");
			Eyebrow.NativeFieldInfoPtr_Model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "Model");
			Eyebrow.NativeFieldInfoPtr_Rend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "Rend");
			Eyebrow.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "col");
			Eyebrow.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "scale");
			Eyebrow.NativeFieldInfoPtr_thickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "thickness");
			Eyebrow.NativeFieldInfoPtr_restingAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, "restingAngle");
			Eyebrow.NativeMethodInfoPtr_SetScale_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, 100680086);
			Eyebrow.NativeMethodInfoPtr_SetThickness_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, 100680087);
			Eyebrow.NativeMethodInfoPtr_SetRestingAngle_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, 100680088);
			Eyebrow.NativeMethodInfoPtr_SetRestingHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, 100680089);
			Eyebrow.NativeMethodInfoPtr_SetColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, 100680090);
			Eyebrow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr, 100680091);
		}

		// Token: 0x0600865B RID: 34395 RVA: 0x00238D78 File Offset: 0x00236F78
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 250703, RefRangeEnd = 250708, XrefRangeStart = 250702, XrefRangeEnd = 250703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScale(float _scale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyebrow.NativeMethodInfoPtr_SetScale_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600865C RID: 34396 RVA: 0x00238DB8 File Offset: 0x00236FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250708, XrefRangeEnd = 250709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetThickness(float thickness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref thickness;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyebrow.NativeMethodInfoPtr_SetThickness_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600865D RID: 34397 RVA: 0x00238DF8 File Offset: 0x00236FF8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 250717, RefRangeEnd = 250721, XrefRangeStart = 250709, XrefRangeEnd = 250717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRestingAngle(float _angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyebrow.NativeMethodInfoPtr_SetRestingAngle_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600865E RID: 34398 RVA: 0x00238E38 File Offset: 0x00237038
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 250723, RefRangeEnd = 250729, XrefRangeStart = 250721, XrefRangeEnd = 250723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRestingHeight(float normalizedHeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalizedHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyebrow.NativeMethodInfoPtr_SetRestingHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600865F RID: 34399 RVA: 0x00238E78 File Offset: 0x00237078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250729, XrefRangeEnd = 250731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor(Color _col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyebrow.NativeMethodInfoPtr_SetColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008660 RID: 34400 RVA: 0x00238EB8 File Offset: 0x002370B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250731, XrefRangeEnd = 250732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Eyebrow() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Eyebrow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Eyebrow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008661 RID: 34401 RVA: 0x0003FDA8 File Offset: 0x0003DFA8
		public Eyebrow(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028D2 RID: 10450
		// (get) Token: 0x06008662 RID: 34402 RVA: 0x00238EF4 File Offset: 0x002370F4
		// (set) Token: 0x06008663 RID: 34403 RVA: 0x0003FDB1 File Offset: 0x0003DFB1
		public unsafe static float eyebrowHeightMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Eyebrow.NativeFieldInfoPtr_eyebrowHeightMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Eyebrow.NativeFieldInfoPtr_eyebrowHeightMultiplier, (void*)(&value));
			}
		}

		// Token: 0x170028D3 RID: 10451
		// (get) Token: 0x06008664 RID: 34404 RVA: 0x00238F10 File Offset: 0x00237110
		// (set) Token: 0x06008665 RID: 34405 RVA: 0x0003FDBF File Offset: 0x0003DFBF
		public unsafe Vector3 EyebrowDefaultScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_EyebrowDefaultScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_EyebrowDefaultScale)) = value;
			}
		}

		// Token: 0x170028D4 RID: 10452
		// (get) Token: 0x06008666 RID: 34406 RVA: 0x00238F38 File Offset: 0x00237138
		// (set) Token: 0x06008667 RID: 34407 RVA: 0x0003FDDA File Offset: 0x0003DFDA
		public unsafe Vector3 EyebrowDefaultLocalPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_EyebrowDefaultLocalPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_EyebrowDefaultLocalPos)) = value;
			}
		}

		// Token: 0x170028D5 RID: 10453
		// (get) Token: 0x06008668 RID: 34408 RVA: 0x00238F60 File Offset: 0x00237160
		// (set) Token: 0x06008669 RID: 34409 RVA: 0x0003FDF5 File Offset: 0x0003DFF5
		public unsafe Eyebrow.ESide Side
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_Side);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_Side)) = value;
			}
		}

		// Token: 0x170028D6 RID: 10454
		// (get) Token: 0x0600866A RID: 34410 RVA: 0x00238F88 File Offset: 0x00237188
		// (set) Token: 0x0600866B RID: 34411 RVA: 0x0003FE10 File Offset: 0x0003E010
		public unsafe Transform Model
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_Model);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_Model), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028D7 RID: 10455
		// (get) Token: 0x0600866C RID: 34412 RVA: 0x00238FB8 File Offset: 0x002371B8
		// (set) Token: 0x0600866D RID: 34413 RVA: 0x0003FE2F File Offset: 0x0003E02F
		public unsafe MeshRenderer Rend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_Rend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_Rend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028D8 RID: 10456
		// (get) Token: 0x0600866E RID: 34414 RVA: 0x00238FE8 File Offset: 0x002371E8
		// (set) Token: 0x0600866F RID: 34415 RVA: 0x0003FE4E File Offset: 0x0003E04E
		public unsafe Color col
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_col);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_col)) = value;
			}
		}

		// Token: 0x170028D9 RID: 10457
		// (get) Token: 0x06008670 RID: 34416 RVA: 0x00239010 File Offset: 0x00237210
		// (set) Token: 0x06008671 RID: 34417 RVA: 0x0003FE69 File Offset: 0x0003E069
		public unsafe float scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_scale)) = value;
			}
		}

		// Token: 0x170028DA RID: 10458
		// (get) Token: 0x06008672 RID: 34418 RVA: 0x00239038 File Offset: 0x00237238
		// (set) Token: 0x06008673 RID: 34419 RVA: 0x0003FE84 File Offset: 0x0003E084
		public unsafe float thickness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_thickness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_thickness)) = value;
			}
		}

		// Token: 0x170028DB RID: 10459
		// (get) Token: 0x06008674 RID: 34420 RVA: 0x00239060 File Offset: 0x00237260
		// (set) Token: 0x06008675 RID: 34421 RVA: 0x0003FE9F File Offset: 0x0003E09F
		public unsafe float restingAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_restingAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Eyebrow.NativeFieldInfoPtr_restingAngle)) = value;
			}
		}

		// Token: 0x04005B76 RID: 23414
		private static readonly IntPtr NativeFieldInfoPtr_eyebrowHeightMultiplier;

		// Token: 0x04005B77 RID: 23415
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowDefaultScale;

		// Token: 0x04005B78 RID: 23416
		private static readonly IntPtr NativeFieldInfoPtr_EyebrowDefaultLocalPos;

		// Token: 0x04005B79 RID: 23417
		private static readonly IntPtr NativeFieldInfoPtr_Side;

		// Token: 0x04005B7A RID: 23418
		private static readonly IntPtr NativeFieldInfoPtr_Model;

		// Token: 0x04005B7B RID: 23419
		private static readonly IntPtr NativeFieldInfoPtr_Rend;

		// Token: 0x04005B7C RID: 23420
		private static readonly IntPtr NativeFieldInfoPtr_col;

		// Token: 0x04005B7D RID: 23421
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x04005B7E RID: 23422
		private static readonly IntPtr NativeFieldInfoPtr_thickness;

		// Token: 0x04005B7F RID: 23423
		private static readonly IntPtr NativeFieldInfoPtr_restingAngle;

		// Token: 0x04005B80 RID: 23424
		private static readonly IntPtr NativeMethodInfoPtr_SetScale_Public_Void_Single_0;

		// Token: 0x04005B81 RID: 23425
		private static readonly IntPtr NativeMethodInfoPtr_SetThickness_Public_Void_Single_0;

		// Token: 0x04005B82 RID: 23426
		private static readonly IntPtr NativeMethodInfoPtr_SetRestingAngle_Public_Void_Single_0;

		// Token: 0x04005B83 RID: 23427
		private static readonly IntPtr NativeMethodInfoPtr_SetRestingHeight_Public_Void_Single_0;

		// Token: 0x04005B84 RID: 23428
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_Color_0;

		// Token: 0x04005B85 RID: 23429
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AF1 RID: 2801
		[OriginalName("Assembly-CSharp.dll", "", "ESide")]
		public enum ESide
		{
			// Token: 0x04008FB5 RID: 36789
			Right,
			// Token: 0x04008FB6 RID: 36790
			Left
		}
	}
}
