using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000590 RID: 1424
	public class PourableModule : ItemModule
	{
		// Token: 0x06007D2E RID: 32046 RVA: 0x00218F78 File Offset: 0x00217178
		// Note: this type is marked as 'beforefieldinit'.
		static PourableModule()
		{
			Il2CppClassPointerStore<PourableModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "PourableModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourableModule>.NativeClassPtr);
			PourableModule.NativeFieldInfoPtr__IsPouring_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "<IsPouring>k__BackingField");
			PourableModule.NativeFieldInfoPtr__NormalizedPourRate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "<NormalizedPourRate>k__BackingField");
			PourableModule.NativeFieldInfoPtr__LiquidLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "<LiquidLevel>k__BackingField");
			PourableModule.NativeFieldInfoPtr_LiquidType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "LiquidType");
			PourableModule.NativeFieldInfoPtr_PourRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "PourRate");
			PourableModule.NativeFieldInfoPtr_AngleFromUpToPour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "AngleFromUpToPour");
			PourableModule.NativeFieldInfoPtr_OnlyEmptyOverFillable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "OnlyEmptyOverFillable");
			PourableModule.NativeFieldInfoPtr_LiquidCapacity_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "LiquidCapacity_L");
			PourableModule.NativeFieldInfoPtr_LiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "LiquidColor");
			PourableModule.NativeFieldInfoPtr_DefaultLiquid_L = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "DefaultLiquid_L");
			PourableModule.NativeFieldInfoPtr_PourParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "PourParticles");
			PourableModule.NativeFieldInfoPtr_PourPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "PourPoint");
			PourableModule.NativeFieldInfoPtr_LiquidContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "LiquidContainer");
			PourableModule.NativeFieldInfoPtr_Draggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "Draggable");
			PourableModule.NativeFieldInfoPtr_DraggableConstraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "DraggableConstraint");
			PourableModule.NativeFieldInfoPtr_PourSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "PourSound");
			PourableModule.NativeFieldInfoPtr_PourParticlesColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "PourParticlesColor");
			PourableModule.NativeFieldInfoPtr_ParticleMinMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "ParticleMinMultiplier");
			PourableModule.NativeFieldInfoPtr_ParticleMaxMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "ParticleMaxMultiplier");
			PourableModule.NativeFieldInfoPtr_particleMinSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "particleMinSizes");
			PourableModule.NativeFieldInfoPtr_particleMaxSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "particleMaxSizes");
			PourableModule.NativeFieldInfoPtr_activeFillable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "activeFillable");
			PourableModule.NativeFieldInfoPtr_timeSinceFillableHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, "timeSinceFillableHit");
			PourableModule.NativeMethodInfoPtr_get_IsPouring_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678964);
			PourableModule.NativeMethodInfoPtr_set_IsPouring_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678965);
			PourableModule.NativeMethodInfoPtr_get_NormalizedPourRate_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678966);
			PourableModule.NativeMethodInfoPtr_set_NormalizedPourRate_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678967);
			PourableModule.NativeMethodInfoPtr_get_LiquidLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678968);
			PourableModule.NativeMethodInfoPtr_set_LiquidLevel_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678969);
			PourableModule.NativeMethodInfoPtr_get_NormalizedLiquidLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678970);
			PourableModule.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678971);
			PourableModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_StationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678972);
			PourableModule.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678973);
			PourableModule.NativeMethodInfoPtr_UpdatePouring_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678974);
			PourableModule.NativeMethodInfoPtr_UpdatePourSound_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678975);
			PourableModule.NativeMethodInfoPtr_ChangeLiquidLevel_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678976);
			PourableModule.NativeMethodInfoPtr_SetLiquidLevel_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678977);
			PourableModule.NativeMethodInfoPtr_PourAmount_Protected_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678978);
			PourableModule.NativeMethodInfoPtr_ParticleCollision_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678979);
			PourableModule.NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678980);
			PourableModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableModule>.NativeClassPtr, 100678981);
		}

		// Token: 0x170025F5 RID: 9717
		// (get) Token: 0x06007D2F RID: 32047 RVA: 0x002192DC File Offset: 0x002174DC
		// (set) Token: 0x06007D30 RID: 32048 RVA: 0x00219318 File Offset: 0x00217518
		public unsafe bool IsPouring
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_get_IsPouring_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_set_IsPouring_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170025F6 RID: 9718
		// (get) Token: 0x06007D31 RID: 32049 RVA: 0x00219358 File Offset: 0x00217558
		// (set) Token: 0x06007D32 RID: 32050 RVA: 0x00219394 File Offset: 0x00217594
		public unsafe float NormalizedPourRate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_get_NormalizedPourRate_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_set_NormalizedPourRate_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170025F7 RID: 9719
		// (get) Token: 0x06007D33 RID: 32051 RVA: 0x002193D4 File Offset: 0x002175D4
		// (set) Token: 0x06007D34 RID: 32052 RVA: 0x00219410 File Offset: 0x00217610
		public unsafe float LiquidLevel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_get_LiquidLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 49120, RefRangeEnd = 49123, XrefRangeStart = 49120, XrefRangeEnd = 49123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_set_LiquidLevel_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170025F8 RID: 9720
		// (get) Token: 0x06007D35 RID: 32053 RVA: 0x00219450 File Offset: 0x00217650
		public unsafe float NormalizedLiquidLevel
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 237608, RefRangeEnd = 237613, XrefRangeStart = 237608, XrefRangeEnd = 237608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_get_NormalizedLiquidLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06007D36 RID: 32054 RVA: 0x0021948C File Offset: 0x0021768C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237613, XrefRangeEnd = 237653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D37 RID: 32055 RVA: 0x002194C8 File Offset: 0x002176C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237653, XrefRangeEnd = 237664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActivateModule(StationItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_StationItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D38 RID: 32056 RVA: 0x00219518 File Offset: 0x00217718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237664, XrefRangeEnd = 237672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D39 RID: 32057 RVA: 0x00219554 File Offset: 0x00217754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237672, XrefRangeEnd = 237698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdatePouring()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_UpdatePouring_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D3A RID: 32058 RVA: 0x00219590 File Offset: 0x00217790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237698, XrefRangeEnd = 237704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePourSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_UpdatePourSound_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D3B RID: 32059 RVA: 0x002195C4 File Offset: 0x002177C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237704, XrefRangeEnd = 237710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ChangeLiquidLevel(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_ChangeLiquidLevel_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D3C RID: 32060 RVA: 0x00219610 File Offset: 0x00217810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237710, XrefRangeEnd = 237716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLiquidLevel(float level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_SetLiquidLevel_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D3D RID: 32061 RVA: 0x0021965C File Offset: 0x0021785C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237716, XrefRangeEnd = 237734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PourAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_PourAmount_Protected_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D3E RID: 32062 RVA: 0x002196A8 File Offset: 0x002178A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237734, XrefRangeEnd = 237743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParticleCollision(GameObject other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr_ParticleCollision_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D3F RID: 32063 RVA: 0x002196EC File Offset: 0x002178EC
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanPour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableModule.NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007D40 RID: 32064 RVA: 0x00219734 File Offset: 0x00217934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237743, XrefRangeEnd = 237748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PourableModule() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourableModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D41 RID: 32065 RVA: 0x0003B75F File Offset: 0x0003995F
		public PourableModule(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025DE RID: 9694
		// (get) Token: 0x06007D42 RID: 32066 RVA: 0x00219770 File Offset: 0x00217970
		// (set) Token: 0x06007D43 RID: 32067 RVA: 0x0003B768 File Offset: 0x00039968
		public unsafe bool _IsPouring_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr__IsPouring_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr__IsPouring_k__BackingField)) = value;
			}
		}

		// Token: 0x170025DF RID: 9695
		// (get) Token: 0x06007D44 RID: 32068 RVA: 0x00219798 File Offset: 0x00217998
		// (set) Token: 0x06007D45 RID: 32069 RVA: 0x0003B783 File Offset: 0x00039983
		public unsafe float _NormalizedPourRate_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr__NormalizedPourRate_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr__NormalizedPourRate_k__BackingField)) = value;
			}
		}

		// Token: 0x170025E0 RID: 9696
		// (get) Token: 0x06007D46 RID: 32070 RVA: 0x002197C0 File Offset: 0x002179C0
		// (set) Token: 0x06007D47 RID: 32071 RVA: 0x0003B79E File Offset: 0x0003999E
		public unsafe float _LiquidLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr__LiquidLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr__LiquidLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x170025E1 RID: 9697
		// (get) Token: 0x06007D48 RID: 32072 RVA: 0x002197E8 File Offset: 0x002179E8
		// (set) Token: 0x06007D49 RID: 32073 RVA: 0x0003B7B9 File Offset: 0x000399B9
		public unsafe string LiquidType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170025E2 RID: 9698
		// (get) Token: 0x06007D4A RID: 32074 RVA: 0x00219810 File Offset: 0x00217A10
		// (set) Token: 0x06007D4B RID: 32075 RVA: 0x0003B7D8 File Offset: 0x000399D8
		public unsafe float PourRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourRate)) = value;
			}
		}

		// Token: 0x170025E3 RID: 9699
		// (get) Token: 0x06007D4C RID: 32076 RVA: 0x00219838 File Offset: 0x00217A38
		// (set) Token: 0x06007D4D RID: 32077 RVA: 0x0003B7F3 File Offset: 0x000399F3
		public unsafe float AngleFromUpToPour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_AngleFromUpToPour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_AngleFromUpToPour)) = value;
			}
		}

		// Token: 0x170025E4 RID: 9700
		// (get) Token: 0x06007D4E RID: 32078 RVA: 0x00219860 File Offset: 0x00217A60
		// (set) Token: 0x06007D4F RID: 32079 RVA: 0x0003B80E File Offset: 0x00039A0E
		public unsafe bool OnlyEmptyOverFillable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_OnlyEmptyOverFillable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_OnlyEmptyOverFillable)) = value;
			}
		}

		// Token: 0x170025E5 RID: 9701
		// (get) Token: 0x06007D50 RID: 32080 RVA: 0x00219888 File Offset: 0x00217A88
		// (set) Token: 0x06007D51 RID: 32081 RVA: 0x0003B829 File Offset: 0x00039A29
		public unsafe float LiquidCapacity_L
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidCapacity_L);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidCapacity_L)) = value;
			}
		}

		// Token: 0x170025E6 RID: 9702
		// (get) Token: 0x06007D52 RID: 32082 RVA: 0x002198B0 File Offset: 0x00217AB0
		// (set) Token: 0x06007D53 RID: 32083 RVA: 0x0003B844 File Offset: 0x00039A44
		public unsafe Color LiquidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidColor)) = value;
			}
		}

		// Token: 0x170025E7 RID: 9703
		// (get) Token: 0x06007D54 RID: 32084 RVA: 0x002198D8 File Offset: 0x00217AD8
		// (set) Token: 0x06007D55 RID: 32085 RVA: 0x0003B85F File Offset: 0x00039A5F
		public unsafe float DefaultLiquid_L
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_DefaultLiquid_L);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_DefaultLiquid_L)) = value;
			}
		}

		// Token: 0x170025E8 RID: 9704
		// (get) Token: 0x06007D56 RID: 32086 RVA: 0x00219900 File Offset: 0x00217B00
		// (set) Token: 0x06007D57 RID: 32087 RVA: 0x0003B87A File Offset: 0x00039A7A
		public unsafe Il2CppReferenceArray<ParticleSystem> PourParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025E9 RID: 9705
		// (get) Token: 0x06007D58 RID: 32088 RVA: 0x00219930 File Offset: 0x00217B30
		// (set) Token: 0x06007D59 RID: 32089 RVA: 0x0003B899 File Offset: 0x00039A99
		public unsafe Transform PourPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025EA RID: 9706
		// (get) Token: 0x06007D5A RID: 32090 RVA: 0x00219960 File Offset: 0x00217B60
		// (set) Token: 0x06007D5B RID: 32091 RVA: 0x0003B8B8 File Offset: 0x00039AB8
		public unsafe LiquidContainer LiquidContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_LiquidContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025EB RID: 9707
		// (get) Token: 0x06007D5C RID: 32092 RVA: 0x00219990 File Offset: 0x00217B90
		// (set) Token: 0x06007D5D RID: 32093 RVA: 0x0003B8D7 File Offset: 0x00039AD7
		public unsafe Draggable Draggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_Draggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_Draggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025EC RID: 9708
		// (get) Token: 0x06007D5E RID: 32094 RVA: 0x002199C0 File Offset: 0x00217BC0
		// (set) Token: 0x06007D5F RID: 32095 RVA: 0x0003B8F6 File Offset: 0x00039AF6
		public unsafe DraggableConstraint DraggableConstraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_DraggableConstraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DraggableConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_DraggableConstraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025ED RID: 9709
		// (get) Token: 0x06007D60 RID: 32096 RVA: 0x002199F0 File Offset: 0x00217BF0
		// (set) Token: 0x06007D61 RID: 32097 RVA: 0x0003B915 File Offset: 0x00039B15
		public unsafe AudioSourceController PourSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025EE RID: 9710
		// (get) Token: 0x06007D62 RID: 32098 RVA: 0x00219A20 File Offset: 0x00217C20
		// (set) Token: 0x06007D63 RID: 32099 RVA: 0x0003B934 File Offset: 0x00039B34
		public unsafe Color PourParticlesColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourParticlesColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_PourParticlesColor)) = value;
			}
		}

		// Token: 0x170025EF RID: 9711
		// (get) Token: 0x06007D64 RID: 32100 RVA: 0x00219A48 File Offset: 0x00217C48
		// (set) Token: 0x06007D65 RID: 32101 RVA: 0x0003B94F File Offset: 0x00039B4F
		public unsafe float ParticleMinMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_ParticleMinMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_ParticleMinMultiplier)) = value;
			}
		}

		// Token: 0x170025F0 RID: 9712
		// (get) Token: 0x06007D66 RID: 32102 RVA: 0x00219A70 File Offset: 0x00217C70
		// (set) Token: 0x06007D67 RID: 32103 RVA: 0x0003B96A File Offset: 0x00039B6A
		public unsafe float ParticleMaxMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_ParticleMaxMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_ParticleMaxMultiplier)) = value;
			}
		}

		// Token: 0x170025F1 RID: 9713
		// (get) Token: 0x06007D68 RID: 32104 RVA: 0x00219A98 File Offset: 0x00217C98
		// (set) Token: 0x06007D69 RID: 32105 RVA: 0x0003B985 File Offset: 0x00039B85
		public unsafe Il2CppStructArray<float> particleMinSizes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_particleMinSizes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_particleMinSizes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025F2 RID: 9714
		// (get) Token: 0x06007D6A RID: 32106 RVA: 0x00219AC8 File Offset: 0x00217CC8
		// (set) Token: 0x06007D6B RID: 32107 RVA: 0x0003B9A4 File Offset: 0x00039BA4
		public unsafe Il2CppStructArray<float> particleMaxSizes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_particleMaxSizes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_particleMaxSizes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025F3 RID: 9715
		// (get) Token: 0x06007D6C RID: 32108 RVA: 0x00219AF8 File Offset: 0x00217CF8
		// (set) Token: 0x06007D6D RID: 32109 RVA: 0x0003B9C3 File Offset: 0x00039BC3
		public unsafe Fillable activeFillable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_activeFillable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Fillable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_activeFillable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025F4 RID: 9716
		// (get) Token: 0x06007D6E RID: 32110 RVA: 0x00219B28 File Offset: 0x00217D28
		// (set) Token: 0x06007D6F RID: 32111 RVA: 0x0003B9E2 File Offset: 0x00039BE2
		public unsafe float timeSinceFillableHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_timeSinceFillableHit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableModule.NativeFieldInfoPtr_timeSinceFillableHit)) = value;
			}
		}

		// Token: 0x0400552B RID: 21803
		private static readonly IntPtr NativeFieldInfoPtr__IsPouring_k__BackingField;

		// Token: 0x0400552C RID: 21804
		private static readonly IntPtr NativeFieldInfoPtr__NormalizedPourRate_k__BackingField;

		// Token: 0x0400552D RID: 21805
		private static readonly IntPtr NativeFieldInfoPtr__LiquidLevel_k__BackingField;

		// Token: 0x0400552E RID: 21806
		private static readonly IntPtr NativeFieldInfoPtr_LiquidType;

		// Token: 0x0400552F RID: 21807
		private static readonly IntPtr NativeFieldInfoPtr_PourRate;

		// Token: 0x04005530 RID: 21808
		private static readonly IntPtr NativeFieldInfoPtr_AngleFromUpToPour;

		// Token: 0x04005531 RID: 21809
		private static readonly IntPtr NativeFieldInfoPtr_OnlyEmptyOverFillable;

		// Token: 0x04005532 RID: 21810
		private static readonly IntPtr NativeFieldInfoPtr_LiquidCapacity_L;

		// Token: 0x04005533 RID: 21811
		private static readonly IntPtr NativeFieldInfoPtr_LiquidColor;

		// Token: 0x04005534 RID: 21812
		private static readonly IntPtr NativeFieldInfoPtr_DefaultLiquid_L;

		// Token: 0x04005535 RID: 21813
		private static readonly IntPtr NativeFieldInfoPtr_PourParticles;

		// Token: 0x04005536 RID: 21814
		private static readonly IntPtr NativeFieldInfoPtr_PourPoint;

		// Token: 0x04005537 RID: 21815
		private static readonly IntPtr NativeFieldInfoPtr_LiquidContainer;

		// Token: 0x04005538 RID: 21816
		private static readonly IntPtr NativeFieldInfoPtr_Draggable;

		// Token: 0x04005539 RID: 21817
		private static readonly IntPtr NativeFieldInfoPtr_DraggableConstraint;

		// Token: 0x0400553A RID: 21818
		private static readonly IntPtr NativeFieldInfoPtr_PourSound;

		// Token: 0x0400553B RID: 21819
		private static readonly IntPtr NativeFieldInfoPtr_PourParticlesColor;

		// Token: 0x0400553C RID: 21820
		private static readonly IntPtr NativeFieldInfoPtr_ParticleMinMultiplier;

		// Token: 0x0400553D RID: 21821
		private static readonly IntPtr NativeFieldInfoPtr_ParticleMaxMultiplier;

		// Token: 0x0400553E RID: 21822
		private static readonly IntPtr NativeFieldInfoPtr_particleMinSizes;

		// Token: 0x0400553F RID: 21823
		private static readonly IntPtr NativeFieldInfoPtr_particleMaxSizes;

		// Token: 0x04005540 RID: 21824
		private static readonly IntPtr NativeFieldInfoPtr_activeFillable;

		// Token: 0x04005541 RID: 21825
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceFillableHit;

		// Token: 0x04005542 RID: 21826
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPouring_Public_get_Boolean_0;

		// Token: 0x04005543 RID: 21827
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPouring_Protected_set_Void_Boolean_0;

		// Token: 0x04005544 RID: 21828
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedPourRate_Public_get_Single_0;

		// Token: 0x04005545 RID: 21829
		private static readonly IntPtr NativeMethodInfoPtr_set_NormalizedPourRate_Private_set_Void_Single_0;

		// Token: 0x04005546 RID: 21830
		private static readonly IntPtr NativeMethodInfoPtr_get_LiquidLevel_Public_get_Single_0;

		// Token: 0x04005547 RID: 21831
		private static readonly IntPtr NativeMethodInfoPtr_set_LiquidLevel_Protected_set_Void_Single_0;

		// Token: 0x04005548 RID: 21832
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedLiquidLevel_Public_get_Single_0;

		// Token: 0x04005549 RID: 21833
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x0400554A RID: 21834
		private static readonly IntPtr NativeMethodInfoPtr_ActivateModule_Public_Virtual_Void_StationItem_0;

		// Token: 0x0400554B RID: 21835
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x0400554C RID: 21836
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePouring_Protected_Virtual_New_Void_0;

		// Token: 0x0400554D RID: 21837
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePourSound_Private_Void_0;

		// Token: 0x0400554E RID: 21838
		private static readonly IntPtr NativeMethodInfoPtr_ChangeLiquidLevel_Public_Virtual_New_Void_Single_0;

		// Token: 0x0400554F RID: 21839
		private static readonly IntPtr NativeMethodInfoPtr_SetLiquidLevel_Public_Virtual_New_Void_Single_0;

		// Token: 0x04005550 RID: 21840
		private static readonly IntPtr NativeMethodInfoPtr_PourAmount_Protected_Virtual_New_Void_Single_0;

		// Token: 0x04005551 RID: 21841
		private static readonly IntPtr NativeMethodInfoPtr_ParticleCollision_Private_Void_GameObject_0;

		// Token: 0x04005552 RID: 21842
		private static readonly IntPtr NativeMethodInfoPtr_CanPour_Protected_Virtual_New_Boolean_0;

		// Token: 0x04005553 RID: 21843
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
