using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000344 RID: 836
	public class ConsumeProductBehaviour : Behaviour
	{
		// Token: 0x06003E56 RID: 15958 RVA: 0x0013BFB0 File Offset: 0x0013A1B0
		// Note: this type is marked as 'beforefieldinit'.
		static ConsumeProductBehaviour()
		{
			Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "ConsumeProductBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr);
			ConsumeProductBehaviour.NativeFieldInfoPtr_JointPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, "JointPrefab");
			ConsumeProductBehaviour.NativeFieldInfoPtr_PipePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, "PipePrefab");
			ConsumeProductBehaviour.NativeFieldInfoPtr__ConsumedProduct_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, "<ConsumedProduct>k__BackingField");
			ConsumeProductBehaviour.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, "product");
			ConsumeProductBehaviour.NativeFieldInfoPtr_consumeRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, "consumeRoutine");
			ConsumeProductBehaviour.NativeFieldInfoPtr_WeedConsumeSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, "WeedConsumeSound");
			ConsumeProductBehaviour.NativeFieldInfoPtr_MethConsumeSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, "MethConsumeSound");
			ConsumeProductBehaviour.NativeFieldInfoPtr_SnortSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, "SnortSound");
			ConsumeProductBehaviour.NativeFieldInfoPtr_SmokeExhaleParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, "SmokeExhaleParticles");
			ConsumeProductBehaviour.NativeFieldInfoPtr_TestProduct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, "TestProduct");
			ConsumeProductBehaviour.NativeFieldInfoPtr_onConsumeDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, "onConsumeDone");
			ConsumeProductBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.ConsumeProductBehaviourAssembly-CSharp.dll_Excuted");
			ConsumeProductBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.ConsumeProductBehaviourAssembly-CSharp.dll_Excuted");
			ConsumeProductBehaviour.NativeMethodInfoPtr_get_ConsumedProduct_Public_get_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670613);
			ConsumeProductBehaviour.NativeMethodInfoPtr_set_ConsumedProduct_Private_set_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670614);
			ConsumeProductBehaviour.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670615);
			ConsumeProductBehaviour.NativeMethodInfoPtr_SendProduct_Public_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670616);
			ConsumeProductBehaviour.NativeMethodInfoPtr_SetProduct_Public_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670617);
			ConsumeProductBehaviour.NativeMethodInfoPtr_ClearEffects_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670618);
			ConsumeProductBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670619);
			ConsumeProductBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670620);
			ConsumeProductBehaviour.NativeMethodInfoPtr_TryConsume_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670621);
			ConsumeProductBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670622);
			ConsumeProductBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670623);
			ConsumeProductBehaviour.NativeMethodInfoPtr_ConsumeWeed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670624);
			ConsumeProductBehaviour.NativeMethodInfoPtr_ConsumeMeth_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670625);
			ConsumeProductBehaviour.NativeMethodInfoPtr_ConsumeCocaine_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670626);
			ConsumeProductBehaviour.NativeMethodInfoPtr_ApplyEffects_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670627);
			ConsumeProductBehaviour.NativeMethodInfoPtr_Clear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670628);
			ConsumeProductBehaviour.NativeMethodInfoPtr_DayPass_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670629);
			ConsumeProductBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670630);
			ConsumeProductBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670631);
			ConsumeProductBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670632);
			ConsumeProductBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670633);
			ConsumeProductBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670634);
			ConsumeProductBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670635);
			ConsumeProductBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670636);
			ConsumeProductBehaviour.NativeMethodInfoPtr_RpcWriter___Server_SendProduct_2622925554_Private_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670637);
			ConsumeProductBehaviour.NativeMethodInfoPtr_RpcLogic___SendProduct_2622925554_Public_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670638);
			ConsumeProductBehaviour.NativeMethodInfoPtr_RpcReader___Server_SendProduct_2622925554_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670639);
			ConsumeProductBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetProduct_2622925554_Private_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670640);
			ConsumeProductBehaviour.NativeMethodInfoPtr_RpcLogic___SetProduct_2622925554_Public_Void_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670641);
			ConsumeProductBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetProduct_2622925554_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670642);
			ConsumeProductBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_ClearEffects_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670643);
			ConsumeProductBehaviour.NativeMethodInfoPtr_RpcLogic___ClearEffects_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670644);
			ConsumeProductBehaviour.NativeMethodInfoPtr_RpcReader___Observers_ClearEffects_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670645);
			ConsumeProductBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_ApplyEffects_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670646);
			ConsumeProductBehaviour.NativeMethodInfoPtr_RpcLogic___ApplyEffects_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670647);
			ConsumeProductBehaviour.NativeMethodInfoPtr_RpcReader___Observers_ApplyEffects_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670648);
			ConsumeProductBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, 100670649);
		}

		// Token: 0x1700134C RID: 4940
		// (get) Token: 0x06003E57 RID: 15959 RVA: 0x0013C3C8 File Offset: 0x0013A5C8
		// (set) Token: 0x06003E58 RID: 15960 RVA: 0x0013C408 File Offset: 0x0013A608
		public unsafe ProductItemInstance ConsumedProduct
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 86724, RefRangeEnd = 86725, XrefRangeStart = 86724, XrefRangeEnd = 86725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.NativeMethodInfoPtr_get_ConsumedProduct_Public_get_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductItemInstance>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146512, XrefRangeEnd = 146513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.NativeMethodInfoPtr_set_ConsumedProduct_Private_set_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003E59 RID: 15961 RVA: 0x0013C44C File Offset: 0x0013A64C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146513, XrefRangeEnd = 146561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConsumeProductBehaviour.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E5A RID: 15962 RVA: 0x0013C488 File Offset: 0x0013A688
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 146583, RefRangeEnd = 146585, XrefRangeStart = 146561, XrefRangeEnd = 146583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendProduct(ProductItemInstance _product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.NativeMethodInfoPtr_SendProduct_Public_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E5B RID: 15963 RVA: 0x0013C4CC File Offset: 0x0013A6CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 146607, RefRangeEnd = 146609, XrefRangeStart = 146585, XrefRangeEnd = 146607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetProduct(ProductItemInstance _product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.NativeMethodInfoPtr_SetProduct_Public_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E5C RID: 15964 RVA: 0x0013C510 File Offset: 0x0013A710
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 146630, RefRangeEnd = 146633, XrefRangeStart = 146609, XrefRangeEnd = 146630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearEffects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.NativeMethodInfoPtr_ClearEffects_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E5D RID: 15965 RVA: 0x0013C544 File Offset: 0x0013A744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146633, XrefRangeEnd = 146635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConsumeProductBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E5E RID: 15966 RVA: 0x0013C580 File Offset: 0x0013A780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146635, XrefRangeEnd = 146637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConsumeProductBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E5F RID: 15967 RVA: 0x0013C5BC File Offset: 0x0013A7BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 146656, RefRangeEnd = 146658, XrefRangeStart = 146637, XrefRangeEnd = 146656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryConsume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.NativeMethodInfoPtr_TryConsume_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E60 RID: 15968 RVA: 0x0013C5F0 File Offset: 0x0013A7F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146658, XrefRangeEnd = 146664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConsumeProductBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E61 RID: 15969 RVA: 0x0013C62C File Offset: 0x0013A82C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146664, XrefRangeEnd = 146672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConsumeProductBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E62 RID: 15970 RVA: 0x0013C668 File Offset: 0x0013A868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146672, XrefRangeEnd = 146679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConsumeWeed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.NativeMethodInfoPtr_ConsumeWeed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E63 RID: 15971 RVA: 0x0013C69C File Offset: 0x0013A89C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146679, XrefRangeEnd = 146686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConsumeMeth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.NativeMethodInfoPtr_ConsumeMeth_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E64 RID: 15972 RVA: 0x0013C6D0 File Offset: 0x0013A8D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146686, XrefRangeEnd = 146693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConsumeCocaine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.NativeMethodInfoPtr_ConsumeCocaine_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E65 RID: 15973 RVA: 0x0013C704 File Offset: 0x0013A904
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 146711, RefRangeEnd = 146714, XrefRangeStart = 146693, XrefRangeEnd = 146711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyEffects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.NativeMethodInfoPtr_ApplyEffects_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E66 RID: 15974 RVA: 0x0013C738 File Offset: 0x0013A938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146714, XrefRangeEnd = 146719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.NativeMethodInfoPtr_Clear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E67 RID: 15975 RVA: 0x0013C76C File Offset: 0x0013A96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146719, XrefRangeEnd = 146720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DayPass(int minsSlept)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minsSlept;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.NativeMethodInfoPtr_DayPass_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E68 RID: 15976 RVA: 0x0013C7AC File Offset: 0x0013A9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConsumeProductBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E69 RID: 15977 RVA: 0x0013C7E8 File Offset: 0x0013A9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146720, XrefRangeEnd = 146725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003E6A RID: 15978 RVA: 0x0013C828 File Offset: 0x0013AA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146725, XrefRangeEnd = 146730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003E6B RID: 15979 RVA: 0x0013C868 File Offset: 0x0013AA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146730, XrefRangeEnd = 146735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003E6C RID: 15980 RVA: 0x0013C8A8 File Offset: 0x0013AAA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146735, XrefRangeEnd = 146762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConsumeProductBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E6D RID: 15981 RVA: 0x0013C8E4 File Offset: 0x0013AAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146762, XrefRangeEnd = 146763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConsumeProductBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E6E RID: 15982 RVA: 0x0013C920 File Offset: 0x0013AB20
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConsumeProductBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E6F RID: 15983 RVA: 0x0013C95C File Offset: 0x0013AB5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146763, XrefRangeEnd = 146782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendProduct_2622925554(ProductItemInstance _product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.NativeMethodInfoPtr_RpcWriter___Server_SendProduct_2622925554_Private_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E70 RID: 15984 RVA: 0x0013C9A0 File Offset: 0x0013ABA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 146607, RefRangeEnd = 146609, XrefRangeStart = 146607, XrefRangeEnd = 146609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendProduct_2622925554(ProductItemInstance _product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.NativeMethodInfoPtr_RpcLogic___SendProduct_2622925554_Public_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E71 RID: 15985 RVA: 0x0013C9E4 File Offset: 0x0013ABE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146782, XrefRangeEnd = 146786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendProduct_2622925554(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.NativeMethodInfoPtr_RpcReader___Server_SendProduct_2622925554_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E72 RID: 15986 RVA: 0x0013CA48 File Offset: 0x0013AC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146786, XrefRangeEnd = 146805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetProduct_2622925554(ProductItemInstance _product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetProduct_2622925554_Private_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E73 RID: 15987 RVA: 0x0013CA8C File Offset: 0x0013AC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetProduct_2622925554(ProductItemInstance _product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.NativeMethodInfoPtr_RpcLogic___SetProduct_2622925554_Public_Void_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E74 RID: 15988 RVA: 0x0013CAD0 File Offset: 0x0013ACD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146805, XrefRangeEnd = 146809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetProduct_2622925554(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetProduct_2622925554_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E75 RID: 15989 RVA: 0x0013CB20 File Offset: 0x0013AD20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146809, XrefRangeEnd = 146827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ClearEffects_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_ClearEffects_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E76 RID: 15990 RVA: 0x0013CB54 File Offset: 0x0013AD54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 146829, RefRangeEnd = 146830, XrefRangeStart = 146827, XrefRangeEnd = 146829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ClearEffects_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.NativeMethodInfoPtr_RpcLogic___ClearEffects_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E77 RID: 15991 RVA: 0x0013CB88 File Offset: 0x0013AD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146830, XrefRangeEnd = 146833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ClearEffects_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.NativeMethodInfoPtr_RpcReader___Observers_ClearEffects_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E78 RID: 15992 RVA: 0x0013CBD8 File Offset: 0x0013ADD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 146711, RefRangeEnd = 146714, XrefRangeStart = 146711, XrefRangeEnd = 146714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ApplyEffects_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_ApplyEffects_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E79 RID: 15993 RVA: 0x0013CC0C File Offset: 0x0013AE0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146833, XrefRangeEnd = 146836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ApplyEffects_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.NativeMethodInfoPtr_RpcLogic___ApplyEffects_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E7A RID: 15994 RVA: 0x0013CC40 File Offset: 0x0013AE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146836, XrefRangeEnd = 146840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ApplyEffects_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.NativeMethodInfoPtr_RpcReader___Observers_ApplyEffects_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E7B RID: 15995 RVA: 0x0013CC90 File Offset: 0x0013AE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConsumeProductBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003E7C RID: 15996 RVA: 0x0001F49A File Offset: 0x0001D69A
		public ConsumeProductBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700133F RID: 4927
		// (get) Token: 0x06003E7D RID: 15997 RVA: 0x0013CCCC File Offset: 0x0013AECC
		// (set) Token: 0x06003E7E RID: 15998 RVA: 0x0001F4A3 File Offset: 0x0001D6A3
		public unsafe AvatarEquippable JointPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.NativeFieldInfoPtr_JointPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.NativeFieldInfoPtr_JointPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001340 RID: 4928
		// (get) Token: 0x06003E7F RID: 15999 RVA: 0x0013CCFC File Offset: 0x0013AEFC
		// (set) Token: 0x06003E80 RID: 16000 RVA: 0x0001F4C2 File Offset: 0x0001D6C2
		public unsafe AvatarEquippable PipePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.NativeFieldInfoPtr_PipePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.NativeFieldInfoPtr_PipePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001341 RID: 4929
		// (get) Token: 0x06003E81 RID: 16001 RVA: 0x0013CD2C File Offset: 0x0013AF2C
		// (set) Token: 0x06003E82 RID: 16002 RVA: 0x0001F4E1 File Offset: 0x0001D6E1
		public unsafe ProductItemInstance _ConsumedProduct_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.NativeFieldInfoPtr__ConsumedProduct_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.NativeFieldInfoPtr__ConsumedProduct_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001342 RID: 4930
		// (get) Token: 0x06003E83 RID: 16003 RVA: 0x0013CD5C File Offset: 0x0013AF5C
		// (set) Token: 0x06003E84 RID: 16004 RVA: 0x0001F500 File Offset: 0x0001D700
		public unsafe ProductItemInstance product
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.NativeFieldInfoPtr_product);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.NativeFieldInfoPtr_product), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001343 RID: 4931
		// (get) Token: 0x06003E85 RID: 16005 RVA: 0x0013CD8C File Offset: 0x0013AF8C
		// (set) Token: 0x06003E86 RID: 16006 RVA: 0x0001F51F File Offset: 0x0001D71F
		public unsafe Coroutine consumeRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.NativeFieldInfoPtr_consumeRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.NativeFieldInfoPtr_consumeRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001344 RID: 4932
		// (get) Token: 0x06003E87 RID: 16007 RVA: 0x0013CDBC File Offset: 0x0013AFBC
		// (set) Token: 0x06003E88 RID: 16008 RVA: 0x0001F53E File Offset: 0x0001D73E
		public unsafe AudioSourceController WeedConsumeSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.NativeFieldInfoPtr_WeedConsumeSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.NativeFieldInfoPtr_WeedConsumeSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001345 RID: 4933
		// (get) Token: 0x06003E89 RID: 16009 RVA: 0x0013CDEC File Offset: 0x0013AFEC
		// (set) Token: 0x06003E8A RID: 16010 RVA: 0x0001F55D File Offset: 0x0001D75D
		public unsafe AudioSourceController MethConsumeSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.NativeFieldInfoPtr_MethConsumeSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.NativeFieldInfoPtr_MethConsumeSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001346 RID: 4934
		// (get) Token: 0x06003E8B RID: 16011 RVA: 0x0013CE1C File Offset: 0x0013B01C
		// (set) Token: 0x06003E8C RID: 16012 RVA: 0x0001F57C File Offset: 0x0001D77C
		public unsafe AudioSourceController SnortSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.NativeFieldInfoPtr_SnortSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.NativeFieldInfoPtr_SnortSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001347 RID: 4935
		// (get) Token: 0x06003E8D RID: 16013 RVA: 0x0013CE4C File Offset: 0x0013B04C
		// (set) Token: 0x06003E8E RID: 16014 RVA: 0x0001F59B File Offset: 0x0001D79B
		public unsafe ParticleSystem SmokeExhaleParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.NativeFieldInfoPtr_SmokeExhaleParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.NativeFieldInfoPtr_SmokeExhaleParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x06003E8F RID: 16015 RVA: 0x0013CE7C File Offset: 0x0013B07C
		// (set) Token: 0x06003E90 RID: 16016 RVA: 0x0001F5BA File Offset: 0x0001D7BA
		public unsafe ProductDefinition TestProduct
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.NativeFieldInfoPtr_TestProduct);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.NativeFieldInfoPtr_TestProduct), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001349 RID: 4937
		// (get) Token: 0x06003E91 RID: 16017 RVA: 0x0013CEAC File Offset: 0x0013B0AC
		// (set) Token: 0x06003E92 RID: 16018 RVA: 0x0001F5D9 File Offset: 0x0001D7D9
		public unsafe UnityEvent onConsumeDone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.NativeFieldInfoPtr_onConsumeDone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.NativeFieldInfoPtr_onConsumeDone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x06003E93 RID: 16019 RVA: 0x0013CEDC File Offset: 0x0013B0DC
		// (set) Token: 0x06003E94 RID: 16020 RVA: 0x0001F5F8 File Offset: 0x0001D7F8
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x06003E95 RID: 16021 RVA: 0x0013CF04 File Offset: 0x0013B104
		// (set) Token: 0x06003E96 RID: 16022 RVA: 0x0001F613 File Offset: 0x0001D813
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002944 RID: 10564
		private static readonly IntPtr NativeFieldInfoPtr_JointPrefab;

		// Token: 0x04002945 RID: 10565
		private static readonly IntPtr NativeFieldInfoPtr_PipePrefab;

		// Token: 0x04002946 RID: 10566
		private static readonly IntPtr NativeFieldInfoPtr__ConsumedProduct_k__BackingField;

		// Token: 0x04002947 RID: 10567
		private static readonly IntPtr NativeFieldInfoPtr_product;

		// Token: 0x04002948 RID: 10568
		private static readonly IntPtr NativeFieldInfoPtr_consumeRoutine;

		// Token: 0x04002949 RID: 10569
		private static readonly IntPtr NativeFieldInfoPtr_WeedConsumeSound;

		// Token: 0x0400294A RID: 10570
		private static readonly IntPtr NativeFieldInfoPtr_MethConsumeSound;

		// Token: 0x0400294B RID: 10571
		private static readonly IntPtr NativeFieldInfoPtr_SnortSound;

		// Token: 0x0400294C RID: 10572
		private static readonly IntPtr NativeFieldInfoPtr_SmokeExhaleParticles;

		// Token: 0x0400294D RID: 10573
		private static readonly IntPtr NativeFieldInfoPtr_TestProduct;

		// Token: 0x0400294E RID: 10574
		private static readonly IntPtr NativeFieldInfoPtr_onConsumeDone;

		// Token: 0x0400294F RID: 10575
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002950 RID: 10576
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002951 RID: 10577
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedProduct_Public_get_ProductItemInstance_0;

		// Token: 0x04002952 RID: 10578
		private static readonly IntPtr NativeMethodInfoPtr_set_ConsumedProduct_Private_set_Void_ProductItemInstance_0;

		// Token: 0x04002953 RID: 10579
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04002954 RID: 10580
		private static readonly IntPtr NativeMethodInfoPtr_SendProduct_Public_Void_ProductItemInstance_0;

		// Token: 0x04002955 RID: 10581
		private static readonly IntPtr NativeMethodInfoPtr_SetProduct_Public_Void_ProductItemInstance_0;

		// Token: 0x04002956 RID: 10582
		private static readonly IntPtr NativeMethodInfoPtr_ClearEffects_Public_Void_0;

		// Token: 0x04002957 RID: 10583
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x04002958 RID: 10584
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0;

		// Token: 0x04002959 RID: 10585
		private static readonly IntPtr NativeMethodInfoPtr_TryConsume_Private_Void_0;

		// Token: 0x0400295A RID: 10586
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x0400295B RID: 10587
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_0;

		// Token: 0x0400295C RID: 10588
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeWeed_Private_Void_0;

		// Token: 0x0400295D RID: 10589
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeMeth_Private_Void_0;

		// Token: 0x0400295E RID: 10590
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeCocaine_Private_Void_0;

		// Token: 0x0400295F RID: 10591
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEffects_Private_Void_0;

		// Token: 0x04002960 RID: 10592
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Private_Void_0;

		// Token: 0x04002961 RID: 10593
		private static readonly IntPtr NativeMethodInfoPtr_DayPass_Private_Void_Int32_0;

		// Token: 0x04002962 RID: 10594
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002963 RID: 10595
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04002964 RID: 10596
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x04002965 RID: 10597
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_2;

		// Token: 0x04002966 RID: 10598
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002967 RID: 10599
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002968 RID: 10600
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002969 RID: 10601
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendProduct_2622925554_Private_Void_ProductItemInstance_0;

		// Token: 0x0400296A RID: 10602
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendProduct_2622925554_Public_Void_ProductItemInstance_0;

		// Token: 0x0400296B RID: 10603
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendProduct_2622925554_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400296C RID: 10604
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetProduct_2622925554_Private_Void_ProductItemInstance_0;

		// Token: 0x0400296D RID: 10605
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetProduct_2622925554_Public_Void_ProductItemInstance_0;

		// Token: 0x0400296E RID: 10606
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetProduct_2622925554_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400296F RID: 10607
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ClearEffects_2166136261_Private_Void_0;

		// Token: 0x04002970 RID: 10608
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ClearEffects_2166136261_Public_Void_0;

		// Token: 0x04002971 RID: 10609
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ClearEffects_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002972 RID: 10610
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ApplyEffects_2166136261_Private_Void_0;

		// Token: 0x04002973 RID: 10611
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ApplyEffects_2166136261_Private_Void_0;

		// Token: 0x04002974 RID: 10612
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ApplyEffects_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002975 RID: 10613
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0200093F RID: 2367
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.ConsumeProductBehaviour+<<ConsumeCocaine>g__ConsumeWeedRoutine|25_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0 : Il2CppSystem.Object
		{
			// Token: 0x0600C761 RID: 51041 RVA: 0x00305DD0 File Offset: 0x00303FD0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0()
			{
				Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, "<<ConsumeCocaine>g__ConsumeWeedRoutine|25_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0>.NativeClassPtr);
				ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0>.NativeClassPtr, "<>1__state");
				ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0>.NativeClassPtr, "<>2__current");
				ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0>.NativeClassPtr, "<>4__this");
				ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0>.NativeClassPtr, 100670650);
				ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0>.NativeClassPtr, 100670651);
				ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0>.NativeClassPtr, 100670652);
				ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0>.NativeClassPtr, 100670653);
				ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0>.NativeClassPtr, 100670654);
				ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0>.NativeClassPtr, 100670655);
			}

			// Token: 0x0600C762 RID: 51042 RVA: 0x00305EB0 File Offset: 0x003040B0
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C763 RID: 51043 RVA: 0x00305EF8 File Offset: 0x003040F8
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C764 RID: 51044 RVA: 0x00305F2C File Offset: 0x0030412C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146473, XrefRangeEnd = 146479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003E23 RID: 15907
			// (get) Token: 0x0600C765 RID: 51045 RVA: 0x00305F68 File Offset: 0x00304168
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C766 RID: 51046 RVA: 0x00305FA8 File Offset: 0x003041A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146479, XrefRangeEnd = 146484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003E24 RID: 15908
			// (get) Token: 0x0600C767 RID: 51047 RVA: 0x00305FDC File Offset: 0x003041DC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C768 RID: 51048 RVA: 0x00061040 File Offset: 0x0005F240
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E20 RID: 15904
			// (get) Token: 0x0600C769 RID: 51049 RVA: 0x0030601C File Offset: 0x0030421C
			// (set) Token: 0x0600C76A RID: 51050 RVA: 0x00061049 File Offset: 0x0005F249
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E21 RID: 15905
			// (get) Token: 0x0600C76B RID: 51051 RVA: 0x00306044 File Offset: 0x00304244
			// (set) Token: 0x0600C76C RID: 51052 RVA: 0x00061064 File Offset: 0x0005F264
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E22 RID: 15906
			// (get) Token: 0x0600C76D RID: 51053 RVA: 0x00306074 File Offset: 0x00304274
			// (set) Token: 0x0600C76E RID: 51054 RVA: 0x00061083 File Offset: 0x0005F283
			public unsafe ConsumeProductBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConsumeProductBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040086F1 RID: 34545
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040086F2 RID: 34546
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040086F3 RID: 34547
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040086F4 RID: 34548
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040086F5 RID: 34549
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040086F6 RID: 34550
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040086F7 RID: 34551
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040086F8 RID: 34552
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040086F9 RID: 34553
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000940 RID: 2368
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.ConsumeProductBehaviour+<<ConsumeMeth>g__ConsumeWeedRoutine|24_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1 : Il2CppSystem.Object
		{
			// Token: 0x0600C76F RID: 51055 RVA: 0x003060A4 File Offset: 0x003042A4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1()
			{
				Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, "<<ConsumeMeth>g__ConsumeWeedRoutine|24_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1>.NativeClassPtr);
				ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1>.NativeClassPtr, "<>1__state");
				ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1>.NativeClassPtr, "<>2__current");
				ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1>.NativeClassPtr, "<>4__this");
				ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1>.NativeClassPtr, 100670656);
				ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1>.NativeClassPtr, 100670657);
				ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1>.NativeClassPtr, 100670658);
				ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1>.NativeClassPtr, 100670659);
				ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1>.NativeClassPtr, 100670660);
				ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1>.NativeClassPtr, 100670661);
			}

			// Token: 0x0600C770 RID: 51056 RVA: 0x00306184 File Offset: 0x00304384
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C771 RID: 51057 RVA: 0x003061CC File Offset: 0x003043CC
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C772 RID: 51058 RVA: 0x00306200 File Offset: 0x00304400
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146484, XrefRangeEnd = 146493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003E28 RID: 15912
			// (get) Token: 0x0600C773 RID: 51059 RVA: 0x0030623C File Offset: 0x0030443C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C774 RID: 51060 RVA: 0x0030627C File Offset: 0x0030447C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146493, XrefRangeEnd = 146498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003E29 RID: 15913
			// (get) Token: 0x0600C775 RID: 51061 RVA: 0x003062B0 File Offset: 0x003044B0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C776 RID: 51062 RVA: 0x000610A2 File Offset: 0x0005F2A2
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E25 RID: 15909
			// (get) Token: 0x0600C777 RID: 51063 RVA: 0x003062F0 File Offset: 0x003044F0
			// (set) Token: 0x0600C778 RID: 51064 RVA: 0x000610AB File Offset: 0x0005F2AB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E26 RID: 15910
			// (get) Token: 0x0600C779 RID: 51065 RVA: 0x00306318 File Offset: 0x00304518
			// (set) Token: 0x0600C77A RID: 51066 RVA: 0x000610C6 File Offset: 0x0005F2C6
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E27 RID: 15911
			// (get) Token: 0x0600C77B RID: 51067 RVA: 0x00306348 File Offset: 0x00304548
			// (set) Token: 0x0600C77C RID: 51068 RVA: 0x000610E5 File Offset: 0x0005F2E5
			public unsafe ConsumeProductBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConsumeProductBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040086FA RID: 34554
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040086FB RID: 34555
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040086FC RID: 34556
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040086FD RID: 34557
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040086FE RID: 34558
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040086FF RID: 34559
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008700 RID: 34560
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008701 RID: 34561
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008702 RID: 34562
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000941 RID: 2369
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.ConsumeProductBehaviour+<<ConsumeWeed>g__ConsumeWeedRoutine|23_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2 : Il2CppSystem.Object
		{
			// Token: 0x0600C77D RID: 51069 RVA: 0x00306378 File Offset: 0x00304578
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2()
			{
				Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConsumeProductBehaviour>.NativeClassPtr, "<<ConsumeWeed>g__ConsumeWeedRoutine|23_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2>.NativeClassPtr);
				ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2>.NativeClassPtr, "<>1__state");
				ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2>.NativeClassPtr, "<>2__current");
				ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2>.NativeClassPtr, "<>4__this");
				ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2>.NativeClassPtr, 100670662);
				ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2>.NativeClassPtr, 100670663);
				ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2>.NativeClassPtr, 100670664);
				ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2>.NativeClassPtr, 100670665);
				ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2>.NativeClassPtr, 100670666);
				ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2>.NativeClassPtr, 100670667);
			}

			// Token: 0x0600C77E RID: 51070 RVA: 0x00306458 File Offset: 0x00304658
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C77F RID: 51071 RVA: 0x003064A0 File Offset: 0x003046A0
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C780 RID: 51072 RVA: 0x003064D4 File Offset: 0x003046D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146498, XrefRangeEnd = 146507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003E2D RID: 15917
			// (get) Token: 0x0600C781 RID: 51073 RVA: 0x00306510 File Offset: 0x00304710
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C782 RID: 51074 RVA: 0x00306550 File Offset: 0x00304750
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146507, XrefRangeEnd = 146512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003E2E RID: 15918
			// (get) Token: 0x0600C783 RID: 51075 RVA: 0x00306584 File Offset: 0x00304784
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C784 RID: 51076 RVA: 0x00061104 File Offset: 0x0005F304
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E2A RID: 15914
			// (get) Token: 0x0600C785 RID: 51077 RVA: 0x003065C4 File Offset: 0x003047C4
			// (set) Token: 0x0600C786 RID: 51078 RVA: 0x0006110D File Offset: 0x0005F30D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E2B RID: 15915
			// (get) Token: 0x0600C787 RID: 51079 RVA: 0x003065EC File Offset: 0x003047EC
			// (set) Token: 0x0600C788 RID: 51080 RVA: 0x00061128 File Offset: 0x0005F328
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E2C RID: 15916
			// (get) Token: 0x0600C789 RID: 51081 RVA: 0x0030661C File Offset: 0x0030481C
			// (set) Token: 0x0600C78A RID: 51082 RVA: 0x00061147 File Offset: 0x0005F347
			public unsafe ConsumeProductBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConsumeProductBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsumeProductBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoVoObMoInVoBoOb2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008703 RID: 34563
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008704 RID: 34564
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008705 RID: 34565
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008706 RID: 34566
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008707 RID: 34567
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008708 RID: 34568
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008709 RID: 34569
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400870A RID: 34570
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400870B RID: 34571
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
