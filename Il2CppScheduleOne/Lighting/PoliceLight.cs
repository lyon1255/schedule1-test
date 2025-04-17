using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003B7 RID: 951
	public class PoliceLight : MonoBehaviour
	{
		// Token: 0x06004A0F RID: 18959 RVA: 0x00167E2C File Offset: 0x0016602C
		// Note: this type is marked as 'beforefieldinit'.
		static PoliceLight()
		{
			Il2CppClassPointerStore<PoliceLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "PoliceLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr);
			PoliceLight.NativeFieldInfoPtr_IsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "IsOn");
			PoliceLight.NativeFieldInfoPtr_RedMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "RedMeshes");
			PoliceLight.NativeFieldInfoPtr_BlueMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "BlueMeshes");
			PoliceLight.NativeFieldInfoPtr_RedLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "RedLights");
			PoliceLight.NativeFieldInfoPtr_BlueLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "BlueLights");
			PoliceLight.NativeFieldInfoPtr_Siren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "Siren");
			PoliceLight.NativeFieldInfoPtr_CycleDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "CycleDuration");
			PoliceLight.NativeFieldInfoPtr_RedOffMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "RedOffMat");
			PoliceLight.NativeFieldInfoPtr_RedOnMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "RedOnMat");
			PoliceLight.NativeFieldInfoPtr_BlueOffMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "BlueOffMat");
			PoliceLight.NativeFieldInfoPtr_BlueOnMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "BlueOnMat");
			PoliceLight.NativeFieldInfoPtr_RedBrightnessCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "RedBrightnessCurve");
			PoliceLight.NativeFieldInfoPtr_BlueBrightnessCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "BlueBrightnessCurve");
			PoliceLight.NativeFieldInfoPtr_LightBrightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "LightBrightness");
			PoliceLight.NativeFieldInfoPtr_cycleRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "cycleRoutine");
			PoliceLight.NativeMethodInfoPtr_SetIsOn_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, 100672483);
			PoliceLight.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, 100672484);
			PoliceLight.NativeMethodInfoPtr_CycleCoroutine_Protected_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, 100672485);
			PoliceLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, 100672486);
		}

		// Token: 0x06004A10 RID: 18960 RVA: 0x00167FD8 File Offset: 0x001661D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOn(bool isOn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight.NativeMethodInfoPtr_SetIsOn_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A11 RID: 18961 RVA: 0x00168018 File Offset: 0x00166218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163722, XrefRangeEnd = 163724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A12 RID: 18962 RVA: 0x0016804C File Offset: 0x0016624C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163724, XrefRangeEnd = 163729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CycleCoroutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight.NativeMethodInfoPtr_CycleCoroutine_Protected_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004A13 RID: 18963 RVA: 0x0016808C File Offset: 0x0016628C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163729, XrefRangeEnd = 163730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoliceLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A14 RID: 18964 RVA: 0x00023ADA File Offset: 0x00021CDA
		public PoliceLight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001630 RID: 5680
		// (get) Token: 0x06004A15 RID: 18965 RVA: 0x001680C8 File Offset: 0x001662C8
		// (set) Token: 0x06004A16 RID: 18966 RVA: 0x00023AE3 File Offset: 0x00021CE3
		public unsafe bool IsOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_IsOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_IsOn)) = value;
			}
		}

		// Token: 0x17001631 RID: 5681
		// (get) Token: 0x06004A17 RID: 18967 RVA: 0x001680F0 File Offset: 0x001662F0
		// (set) Token: 0x06004A18 RID: 18968 RVA: 0x00023AFE File Offset: 0x00021CFE
		public unsafe Il2CppReferenceArray<MeshRenderer> RedMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001632 RID: 5682
		// (get) Token: 0x06004A19 RID: 18969 RVA: 0x00168120 File Offset: 0x00166320
		// (set) Token: 0x06004A1A RID: 18970 RVA: 0x00023B1D File Offset: 0x00021D1D
		public unsafe Il2CppReferenceArray<MeshRenderer> BlueMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001633 RID: 5683
		// (get) Token: 0x06004A1B RID: 18971 RVA: 0x00168150 File Offset: 0x00166350
		// (set) Token: 0x06004A1C RID: 18972 RVA: 0x00023B3C File Offset: 0x00021D3C
		public unsafe Il2CppReferenceArray<OptimizedLight> RedLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedLights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<OptimizedLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedLights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001634 RID: 5684
		// (get) Token: 0x06004A1D RID: 18973 RVA: 0x00168180 File Offset: 0x00166380
		// (set) Token: 0x06004A1E RID: 18974 RVA: 0x00023B5B File Offset: 0x00021D5B
		public unsafe Il2CppReferenceArray<OptimizedLight> BlueLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueLights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<OptimizedLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueLights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001635 RID: 5685
		// (get) Token: 0x06004A1F RID: 18975 RVA: 0x001681B0 File Offset: 0x001663B0
		// (set) Token: 0x06004A20 RID: 18976 RVA: 0x00023B7A File Offset: 0x00021D7A
		public unsafe AudioSourceController Siren
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_Siren);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_Siren), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001636 RID: 5686
		// (get) Token: 0x06004A21 RID: 18977 RVA: 0x001681E0 File Offset: 0x001663E0
		// (set) Token: 0x06004A22 RID: 18978 RVA: 0x00023B99 File Offset: 0x00021D99
		public unsafe float CycleDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_CycleDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_CycleDuration)) = value;
			}
		}

		// Token: 0x17001637 RID: 5687
		// (get) Token: 0x06004A23 RID: 18979 RVA: 0x00168208 File Offset: 0x00166408
		// (set) Token: 0x06004A24 RID: 18980 RVA: 0x00023BB4 File Offset: 0x00021DB4
		public unsafe Material RedOffMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedOffMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedOffMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001638 RID: 5688
		// (get) Token: 0x06004A25 RID: 18981 RVA: 0x00168238 File Offset: 0x00166438
		// (set) Token: 0x06004A26 RID: 18982 RVA: 0x00023BD3 File Offset: 0x00021DD3
		public unsafe Material RedOnMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedOnMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedOnMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001639 RID: 5689
		// (get) Token: 0x06004A27 RID: 18983 RVA: 0x00168268 File Offset: 0x00166468
		// (set) Token: 0x06004A28 RID: 18984 RVA: 0x00023BF2 File Offset: 0x00021DF2
		public unsafe Material BlueOffMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueOffMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueOffMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700163A RID: 5690
		// (get) Token: 0x06004A29 RID: 18985 RVA: 0x00168298 File Offset: 0x00166498
		// (set) Token: 0x06004A2A RID: 18986 RVA: 0x00023C11 File Offset: 0x00021E11
		public unsafe Material BlueOnMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueOnMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueOnMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700163B RID: 5691
		// (get) Token: 0x06004A2B RID: 18987 RVA: 0x001682C8 File Offset: 0x001664C8
		// (set) Token: 0x06004A2C RID: 18988 RVA: 0x00023C30 File Offset: 0x00021E30
		public unsafe AnimationCurve RedBrightnessCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedBrightnessCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedBrightnessCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700163C RID: 5692
		// (get) Token: 0x06004A2D RID: 18989 RVA: 0x001682F8 File Offset: 0x001664F8
		// (set) Token: 0x06004A2E RID: 18990 RVA: 0x00023C4F File Offset: 0x00021E4F
		public unsafe AnimationCurve BlueBrightnessCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueBrightnessCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueBrightnessCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700163D RID: 5693
		// (get) Token: 0x06004A2F RID: 18991 RVA: 0x00168328 File Offset: 0x00166528
		// (set) Token: 0x06004A30 RID: 18992 RVA: 0x00023C6E File Offset: 0x00021E6E
		public unsafe float LightBrightness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_LightBrightness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_LightBrightness)) = value;
			}
		}

		// Token: 0x1700163E RID: 5694
		// (get) Token: 0x06004A31 RID: 18993 RVA: 0x00168350 File Offset: 0x00166550
		// (set) Token: 0x06004A32 RID: 18994 RVA: 0x00023C89 File Offset: 0x00021E89
		public unsafe Coroutine cycleRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_cycleRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_cycleRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031EC RID: 12780
		private static readonly IntPtr NativeFieldInfoPtr_IsOn;

		// Token: 0x040031ED RID: 12781
		private static readonly IntPtr NativeFieldInfoPtr_RedMeshes;

		// Token: 0x040031EE RID: 12782
		private static readonly IntPtr NativeFieldInfoPtr_BlueMeshes;

		// Token: 0x040031EF RID: 12783
		private static readonly IntPtr NativeFieldInfoPtr_RedLights;

		// Token: 0x040031F0 RID: 12784
		private static readonly IntPtr NativeFieldInfoPtr_BlueLights;

		// Token: 0x040031F1 RID: 12785
		private static readonly IntPtr NativeFieldInfoPtr_Siren;

		// Token: 0x040031F2 RID: 12786
		private static readonly IntPtr NativeFieldInfoPtr_CycleDuration;

		// Token: 0x040031F3 RID: 12787
		private static readonly IntPtr NativeFieldInfoPtr_RedOffMat;

		// Token: 0x040031F4 RID: 12788
		private static readonly IntPtr NativeFieldInfoPtr_RedOnMat;

		// Token: 0x040031F5 RID: 12789
		private static readonly IntPtr NativeFieldInfoPtr_BlueOffMat;

		// Token: 0x040031F6 RID: 12790
		private static readonly IntPtr NativeFieldInfoPtr_BlueOnMat;

		// Token: 0x040031F7 RID: 12791
		private static readonly IntPtr NativeFieldInfoPtr_RedBrightnessCurve;

		// Token: 0x040031F8 RID: 12792
		private static readonly IntPtr NativeFieldInfoPtr_BlueBrightnessCurve;

		// Token: 0x040031F9 RID: 12793
		private static readonly IntPtr NativeFieldInfoPtr_LightBrightness;

		// Token: 0x040031FA RID: 12794
		private static readonly IntPtr NativeFieldInfoPtr_cycleRoutine;

		// Token: 0x040031FB RID: 12795
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOn_Public_Void_Boolean_0;

		// Token: 0x040031FC RID: 12796
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040031FD RID: 12797
		private static readonly IntPtr NativeMethodInfoPtr_CycleCoroutine_Protected_IEnumerator_0;

		// Token: 0x040031FE RID: 12798
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000985 RID: 2437
		[ObfuscatedName("ScheduleOne.Lighting.PoliceLight+<CycleCoroutine>d__17")]
		public sealed class _CycleCoroutine_d__17 : Il2CppSystem.Object
		{
			// Token: 0x0600CA22 RID: 51746 RVA: 0x0030E44C File Offset: 0x0030C64C
			// Note: this type is marked as 'beforefieldinit'.
			static _CycleCoroutine_d__17()
			{
				Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "<CycleCoroutine>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr);
				PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, "<>1__state");
				PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, "<>2__current");
				PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, "<>4__this");
				PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr__time_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, "<time>5__2");
				PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, 100672487);
				PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, 100672488);
				PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, 100672489);
				PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, 100672490);
				PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, 100672491);
				PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, 100672492);
			}

			// Token: 0x0600CA23 RID: 51747 RVA: 0x0030E540 File Offset: 0x0030C740
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CycleCoroutine_d__17(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA24 RID: 51748 RVA: 0x0030E588 File Offset: 0x0030C788
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA25 RID: 51749 RVA: 0x0030E5BC File Offset: 0x0030C7BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163683, XrefRangeEnd = 163717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003F00 RID: 16128
			// (get) Token: 0x0600CA26 RID: 51750 RVA: 0x0030E5F8 File Offset: 0x0030C7F8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CA27 RID: 51751 RVA: 0x0030E638 File Offset: 0x0030C838
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163717, XrefRangeEnd = 163722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003F01 RID: 16129
			// (get) Token: 0x0600CA28 RID: 51752 RVA: 0x0030E66C File Offset: 0x0030C86C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600CA29 RID: 51753 RVA: 0x00062476 File Offset: 0x00060676
			public _CycleCoroutine_d__17(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EFC RID: 16124
			// (get) Token: 0x0600CA2A RID: 51754 RVA: 0x0030E6AC File Offset: 0x0030C8AC
			// (set) Token: 0x0600CA2B RID: 51755 RVA: 0x0006247F File Offset: 0x0006067F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003EFD RID: 16125
			// (get) Token: 0x0600CA2C RID: 51756 RVA: 0x0030E6D4 File Offset: 0x0030C8D4
			// (set) Token: 0x0600CA2D RID: 51757 RVA: 0x0006249A File Offset: 0x0006069A
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EFE RID: 16126
			// (get) Token: 0x0600CA2E RID: 51758 RVA: 0x0030E704 File Offset: 0x0030C904
			// (set) Token: 0x0600CA2F RID: 51759 RVA: 0x000624B9 File Offset: 0x000606B9
			public unsafe PoliceLight __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceLight>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EFF RID: 16127
			// (get) Token: 0x0600CA30 RID: 51760 RVA: 0x0030E734 File Offset: 0x0030C934
			// (set) Token: 0x0600CA31 RID: 51761 RVA: 0x000624D8 File Offset: 0x000606D8
			public unsafe float _time_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr__time_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr__time_5__2)) = value;
				}
			}

			// Token: 0x040088BC RID: 35004
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040088BD RID: 35005
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040088BE RID: 35006
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040088BF RID: 35007
			private static readonly IntPtr NativeFieldInfoPtr__time_5__2;

			// Token: 0x040088C0 RID: 35008
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040088C1 RID: 35009
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040088C2 RID: 35010
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040088C3 RID: 35011
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040088C4 RID: 35012
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040088C5 RID: 35013
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
