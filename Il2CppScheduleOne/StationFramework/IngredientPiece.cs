using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000589 RID: 1417
	public class IngredientPiece : MonoBehaviour
	{
		// Token: 0x06007CB5 RID: 31925 RVA: 0x002179C0 File Offset: 0x00215BC0
		// Note: this type is marked as 'beforefieldinit'.
		static IngredientPiece()
		{
			Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "IngredientPiece");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr);
			IngredientPiece.NativeFieldInfoPtr_LIQUID_FRICTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "LIQUID_FRICTION");
			IngredientPiece.NativeFieldInfoPtr__CurrentDissolveAmount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "<CurrentDissolveAmount>k__BackingField");
			IngredientPiece.NativeFieldInfoPtr_CurrentLiquidContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "CurrentLiquidContainer");
			IngredientPiece.NativeFieldInfoPtr_ModelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "ModelContainer");
			IngredientPiece.NativeFieldInfoPtr_DissolveParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "DissolveParticles");
			IngredientPiece.NativeFieldInfoPtr_DetectLiquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "DetectLiquid");
			IngredientPiece.NativeFieldInfoPtr_DisableInteractionInLiquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "DisableInteractionInLiquid");
			IngredientPiece.NativeFieldInfoPtr_LiquidFrictionMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "LiquidFrictionMultiplier");
			IngredientPiece.NativeFieldInfoPtr_draggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "draggable");
			IngredientPiece.NativeFieldInfoPtr_defaultDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "defaultDrag");
			IngredientPiece.NativeFieldInfoPtr_dissolveParticleRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "dissolveParticleRoutine");
			IngredientPiece.NativeMethodInfoPtr_get_CurrentDissolveAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678921);
			IngredientPiece.NativeMethodInfoPtr_set_CurrentDissolveAmount_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678922);
			IngredientPiece.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678923);
			IngredientPiece.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678924);
			IngredientPiece.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678925);
			IngredientPiece.NativeMethodInfoPtr_UpdateDrag_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678926);
			IngredientPiece.NativeMethodInfoPtr_CheckLiquid_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678927);
			IngredientPiece.NativeMethodInfoPtr_DissolveAmount_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678928);
			IngredientPiece.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678929);
			IngredientPiece.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, 100678930);
		}

		// Token: 0x170025C1 RID: 9665
		// (get) Token: 0x06007CB6 RID: 31926 RVA: 0x00217B94 File Offset: 0x00215D94
		// (set) Token: 0x06007CB7 RID: 31927 RVA: 0x00217BD0 File Offset: 0x00215DD0
		public unsafe float CurrentDissolveAmount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_get_CurrentDissolveAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29961, RefRangeEnd = 29962, XrefRangeStart = 29961, XrefRangeEnd = 29962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_set_CurrentDissolveAmount_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007CB8 RID: 31928 RVA: 0x00217C10 File Offset: 0x00215E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237396, XrefRangeEnd = 237403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CB9 RID: 31929 RVA: 0x00217C44 File Offset: 0x00215E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237403, XrefRangeEnd = 237407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CBA RID: 31930 RVA: 0x00217C78 File Offset: 0x00215E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237407, XrefRangeEnd = 237408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CBB RID: 31931 RVA: 0x00217CAC File Offset: 0x00215EAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 237428, RefRangeEnd = 237429, XrefRangeStart = 237408, XrefRangeEnd = 237428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_UpdateDrag_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CBC RID: 31932 RVA: 0x00217CE0 File Offset: 0x00215EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237429, XrefRangeEnd = 237445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckLiquid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_CheckLiquid_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CBD RID: 31933 RVA: 0x00217D14 File Offset: 0x00215F14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 237460, RefRangeEnd = 237461, XrefRangeStart = 237445, XrefRangeEnd = 237460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DissolveAmount(float amount, bool showParticles = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showParticles;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_DissolveAmount_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CBE RID: 31934 RVA: 0x00217D60 File Offset: 0x00215F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237461, XrefRangeEnd = 237462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IngredientPiece() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CBF RID: 31935 RVA: 0x00217D9C File Offset: 0x00215F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237462, XrefRangeEnd = 237467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06007CC0 RID: 31936 RVA: 0x0003B330 File Offset: 0x00039530
		public IngredientPiece(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025B6 RID: 9654
		// (get) Token: 0x06007CC1 RID: 31937 RVA: 0x00217DDC File Offset: 0x00215FDC
		// (set) Token: 0x06007CC2 RID: 31938 RVA: 0x0003B339 File Offset: 0x00039539
		public unsafe static float LIQUID_FRICTION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(IngredientPiece.NativeFieldInfoPtr_LIQUID_FRICTION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IngredientPiece.NativeFieldInfoPtr_LIQUID_FRICTION, (void*)(&value));
			}
		}

		// Token: 0x170025B7 RID: 9655
		// (get) Token: 0x06007CC3 RID: 31939 RVA: 0x00217DF8 File Offset: 0x00215FF8
		// (set) Token: 0x06007CC4 RID: 31940 RVA: 0x0003B347 File Offset: 0x00039547
		public unsafe float _CurrentDissolveAmount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr__CurrentDissolveAmount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr__CurrentDissolveAmount_k__BackingField)) = value;
			}
		}

		// Token: 0x170025B8 RID: 9656
		// (get) Token: 0x06007CC5 RID: 31941 RVA: 0x00217E20 File Offset: 0x00216020
		// (set) Token: 0x06007CC6 RID: 31942 RVA: 0x0003B362 File Offset: 0x00039562
		public unsafe LiquidContainer CurrentLiquidContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_CurrentLiquidContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_CurrentLiquidContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025B9 RID: 9657
		// (get) Token: 0x06007CC7 RID: 31943 RVA: 0x00217E50 File Offset: 0x00216050
		// (set) Token: 0x06007CC8 RID: 31944 RVA: 0x0003B381 File Offset: 0x00039581
		public unsafe Transform ModelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_ModelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_ModelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025BA RID: 9658
		// (get) Token: 0x06007CC9 RID: 31945 RVA: 0x00217E80 File Offset: 0x00216080
		// (set) Token: 0x06007CCA RID: 31946 RVA: 0x0003B3A0 File Offset: 0x000395A0
		public unsafe ParticleSystem DissolveParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_DissolveParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_DissolveParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025BB RID: 9659
		// (get) Token: 0x06007CCB RID: 31947 RVA: 0x00217EB0 File Offset: 0x002160B0
		// (set) Token: 0x06007CCC RID: 31948 RVA: 0x0003B3BF File Offset: 0x000395BF
		public unsafe bool DetectLiquid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_DetectLiquid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_DetectLiquid)) = value;
			}
		}

		// Token: 0x170025BC RID: 9660
		// (get) Token: 0x06007CCD RID: 31949 RVA: 0x00217ED8 File Offset: 0x002160D8
		// (set) Token: 0x06007CCE RID: 31950 RVA: 0x0003B3DA File Offset: 0x000395DA
		public unsafe bool DisableInteractionInLiquid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_DisableInteractionInLiquid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_DisableInteractionInLiquid)) = value;
			}
		}

		// Token: 0x170025BD RID: 9661
		// (get) Token: 0x06007CCF RID: 31951 RVA: 0x00217F00 File Offset: 0x00216100
		// (set) Token: 0x06007CD0 RID: 31952 RVA: 0x0003B3F5 File Offset: 0x000395F5
		public unsafe float LiquidFrictionMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_LiquidFrictionMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_LiquidFrictionMultiplier)) = value;
			}
		}

		// Token: 0x170025BE RID: 9662
		// (get) Token: 0x06007CD1 RID: 31953 RVA: 0x00217F28 File Offset: 0x00216128
		// (set) Token: 0x06007CD2 RID: 31954 RVA: 0x0003B410 File Offset: 0x00039610
		public unsafe Draggable draggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_draggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_draggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025BF RID: 9663
		// (get) Token: 0x06007CD3 RID: 31955 RVA: 0x00217F58 File Offset: 0x00216158
		// (set) Token: 0x06007CD4 RID: 31956 RVA: 0x0003B42F File Offset: 0x0003962F
		public unsafe float defaultDrag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_defaultDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_defaultDrag)) = value;
			}
		}

		// Token: 0x170025C0 RID: 9664
		// (get) Token: 0x06007CD5 RID: 31957 RVA: 0x00217F80 File Offset: 0x00216180
		// (set) Token: 0x06007CD6 RID: 31958 RVA: 0x0003B44A File Offset: 0x0003964A
		public unsafe Coroutine dissolveParticleRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_dissolveParticleRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.NativeFieldInfoPtr_dissolveParticleRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040054E3 RID: 21731
		private static readonly IntPtr NativeFieldInfoPtr_LIQUID_FRICTION;

		// Token: 0x040054E4 RID: 21732
		private static readonly IntPtr NativeFieldInfoPtr__CurrentDissolveAmount_k__BackingField;

		// Token: 0x040054E5 RID: 21733
		private static readonly IntPtr NativeFieldInfoPtr_CurrentLiquidContainer;

		// Token: 0x040054E6 RID: 21734
		private static readonly IntPtr NativeFieldInfoPtr_ModelContainer;

		// Token: 0x040054E7 RID: 21735
		private static readonly IntPtr NativeFieldInfoPtr_DissolveParticles;

		// Token: 0x040054E8 RID: 21736
		private static readonly IntPtr NativeFieldInfoPtr_DetectLiquid;

		// Token: 0x040054E9 RID: 21737
		private static readonly IntPtr NativeFieldInfoPtr_DisableInteractionInLiquid;

		// Token: 0x040054EA RID: 21738
		private static readonly IntPtr NativeFieldInfoPtr_LiquidFrictionMultiplier;

		// Token: 0x040054EB RID: 21739
		private static readonly IntPtr NativeFieldInfoPtr_draggable;

		// Token: 0x040054EC RID: 21740
		private static readonly IntPtr NativeFieldInfoPtr_defaultDrag;

		// Token: 0x040054ED RID: 21741
		private static readonly IntPtr NativeFieldInfoPtr_dissolveParticleRoutine;

		// Token: 0x040054EE RID: 21742
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDissolveAmount_Public_get_Single_0;

		// Token: 0x040054EF RID: 21743
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentDissolveAmount_Private_set_Void_Single_0;

		// Token: 0x040054F0 RID: 21744
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040054F1 RID: 21745
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040054F2 RID: 21746
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040054F3 RID: 21747
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDrag_Private_Void_0;

		// Token: 0x040054F4 RID: 21748
		private static readonly IntPtr NativeMethodInfoPtr_CheckLiquid_Private_Void_0;

		// Token: 0x040054F5 RID: 21749
		private static readonly IntPtr NativeMethodInfoPtr_DissolveAmount_Public_Void_Single_Boolean_0;

		// Token: 0x040054F6 RID: 21750
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040054F7 RID: 21751
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000ABA RID: 2746
		[ObfuscatedName("ScheduleOne.StationFramework.IngredientPiece+<<DissolveAmount>g__DissolveParticlesRoutine|19_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D3D1 RID: 54225 RVA: 0x003293AC File Offset: 0x003275AC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique()
			{
				Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IngredientPiece>.NativeClassPtr, "<<DissolveAmount>g__DissolveParticlesRoutine|19_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr);
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, "<>1__state");
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, "<>2__current");
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, "<>4__this");
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100678931);
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100678932);
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100678933);
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100678934);
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100678935);
				IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100678936);
			}

			// Token: 0x0600D3D2 RID: 54226 RVA: 0x0032948C File Offset: 0x0032768C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3D3 RID: 54227 RVA: 0x003294D4 File Offset: 0x003276D4
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D3D4 RID: 54228 RVA: 0x00329508 File Offset: 0x00327708
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237386, XrefRangeEnd = 237391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170041B0 RID: 16816
			// (get) Token: 0x0600D3D5 RID: 54229 RVA: 0x00329544 File Offset: 0x00327744
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D3D6 RID: 54230 RVA: 0x00329584 File Offset: 0x00327784
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237391, XrefRangeEnd = 237396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170041B1 RID: 16817
			// (get) Token: 0x0600D3D7 RID: 54231 RVA: 0x003295B8 File Offset: 0x003277B8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D3D8 RID: 54232 RVA: 0x000671D7 File Offset: 0x000653D7
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041AD RID: 16813
			// (get) Token: 0x0600D3D9 RID: 54233 RVA: 0x003295F8 File Offset: 0x003277F8
			// (set) Token: 0x0600D3DA RID: 54234 RVA: 0x000671E0 File Offset: 0x000653E0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170041AE RID: 16814
			// (get) Token: 0x0600D3DB RID: 54235 RVA: 0x00329620 File Offset: 0x00327820
			// (set) Token: 0x0600D3DC RID: 54236 RVA: 0x000671FB File Offset: 0x000653FB
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041AF RID: 16815
			// (get) Token: 0x0600D3DD RID: 54237 RVA: 0x00329650 File Offset: 0x00327850
			// (set) Token: 0x0600D3DE RID: 54238 RVA: 0x0006721A File Offset: 0x0006541A
			public unsafe IngredientPiece __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IngredientPiece>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IngredientPiece.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008EA8 RID: 36520
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008EA9 RID: 36521
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008EAA RID: 36522
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008EAB RID: 36523
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008EAC RID: 36524
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008EAD RID: 36525
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008EAE RID: 36526
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008EAF RID: 36527
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008EB0 RID: 36528
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
