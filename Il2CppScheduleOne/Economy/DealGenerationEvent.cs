using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Quests;
using Il2CppScheduleOne.UI.Phone.Messages;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000412 RID: 1042
	[Serializable]
	public class DealGenerationEvent : Object
	{
		// Token: 0x06005B4B RID: 23371 RVA: 0x001A8138 File Offset: 0x001A6338
		// Note: this type is marked as 'beforefieldinit'.
		static DealGenerationEvent()
		{
			Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "DealGenerationEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr);
			DealGenerationEvent.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "Enabled");
			DealGenerationEvent.NativeFieldInfoPtr_CanBeAccepted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "CanBeAccepted");
			DealGenerationEvent.NativeFieldInfoPtr_CanBeRejected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "CanBeRejected");
			DealGenerationEvent.NativeFieldInfoPtr_ApplicableDays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "ApplicableDays");
			DealGenerationEvent.NativeFieldInfoPtr_GenerationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "GenerationTime");
			DealGenerationEvent.NativeFieldInfoPtr_GenerationWindowDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "GenerationWindowDuration");
			DealGenerationEvent.NativeFieldInfoPtr_ProductList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "ProductList");
			DealGenerationEvent.NativeFieldInfoPtr_Payment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "Payment");
			DealGenerationEvent.NativeFieldInfoPtr_RelationshipRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "RelationshipRequirement");
			DealGenerationEvent.NativeFieldInfoPtr_RequestMessageChains = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "RequestMessageChains");
			DealGenerationEvent.NativeFieldInfoPtr_ContractAcceptedResponses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "ContractAcceptedResponses");
			DealGenerationEvent.NativeFieldInfoPtr_ContractRejectedResponses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "ContractRejectedResponses");
			DealGenerationEvent.NativeFieldInfoPtr_DeliveryLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "DeliveryLocation");
			DealGenerationEvent.NativeFieldInfoPtr_PickupScheduleGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "PickupScheduleGroup");
			DealGenerationEvent.NativeFieldInfoPtr_DeliveryWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "DeliveryWindow");
			DealGenerationEvent.NativeFieldInfoPtr_Expires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "Expires");
			DealGenerationEvent.NativeFieldInfoPtr_ExpiresAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "ExpiresAfter");
			DealGenerationEvent.NativeMethodInfoPtr_GenerateContractInfo_Public_ContractInfo_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, 100674957);
			DealGenerationEvent.NativeMethodInfoPtr_ShouldGenerate_Public_Boolean_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, 100674958);
			DealGenerationEvent.NativeMethodInfoPtr_GetRandomRequestMessage_Public_MessageChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, 100674959);
			DealGenerationEvent.NativeMethodInfoPtr_ProcessMessage_Public_MessageChain_MessageChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, 100674960);
			DealGenerationEvent.NativeMethodInfoPtr_GetRejectionMessage_Public_MessageChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, 100674961);
			DealGenerationEvent.NativeMethodInfoPtr_GetAcceptanceMessage_Public_MessageChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, 100674962);
			DealGenerationEvent.NativeMethodInfoPtr_GetProductStringList_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, 100674963);
			DealGenerationEvent.NativeMethodInfoPtr_GetQualityString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, 100674964);
			DealGenerationEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, 100674965);
		}

		// Token: 0x06005B4C RID: 23372 RVA: 0x001A8370 File Offset: 0x001A6570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193196, XrefRangeEnd = 193201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContractInfo GenerateContractInfo(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.NativeMethodInfoPtr_GenerateContractInfo_Public_ContractInfo_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContractInfo>(intPtr3) : null;
		}

		// Token: 0x06005B4D RID: 23373 RVA: 0x001A83C0 File Offset: 0x001A65C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193201, XrefRangeEnd = 193224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldGenerate(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.NativeMethodInfoPtr_ShouldGenerate_Public_Boolean_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005B4E RID: 23374 RVA: 0x001A8410 File Offset: 0x001A6610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193224, XrefRangeEnd = 193228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageChain GetRandomRequestMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.NativeMethodInfoPtr_GetRandomRequestMessage_Public_MessageChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr3) : null;
		}

		// Token: 0x06005B4F RID: 23375 RVA: 0x001A8450 File Offset: 0x001A6650
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 193279, RefRangeEnd = 193282, XrefRangeStart = 193228, XrefRangeEnd = 193279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageChain ProcessMessage(MessageChain messageChain)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(messageChain);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.NativeMethodInfoPtr_ProcessMessage_Public_MessageChain_MessageChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr3) : null;
		}

		// Token: 0x06005B50 RID: 23376 RVA: 0x001A84A0 File Offset: 0x001A66A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193282, XrefRangeEnd = 193286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageChain GetRejectionMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.NativeMethodInfoPtr_GetRejectionMessage_Public_MessageChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr3) : null;
		}

		// Token: 0x06005B51 RID: 23377 RVA: 0x001A84E0 File Offset: 0x001A66E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193286, XrefRangeEnd = 193290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageChain GetAcceptanceMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.NativeMethodInfoPtr_GetAcceptanceMessage_Public_MessageChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr3) : null;
		}

		// Token: 0x06005B52 RID: 23378 RVA: 0x001A8520 File Offset: 0x001A6720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193290, XrefRangeEnd = 193292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetProductStringList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.NativeMethodInfoPtr_GetProductStringList_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005B53 RID: 23379 RVA: 0x001A8558 File Offset: 0x001A6758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193292, XrefRangeEnd = 193294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetQualityString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.NativeMethodInfoPtr_GetQualityString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005B54 RID: 23380 RVA: 0x001A8590 File Offset: 0x001A6790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193294, XrefRangeEnd = 193302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealGenerationEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B55 RID: 23381 RVA: 0x0002B045 File Offset: 0x00029245
		public DealGenerationEvent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B75 RID: 7029
		// (get) Token: 0x06005B56 RID: 23382 RVA: 0x001A85CC File Offset: 0x001A67CC
		// (set) Token: 0x06005B57 RID: 23383 RVA: 0x0002B04E File Offset: 0x0002924E
		public unsafe bool Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_Enabled)) = value;
			}
		}

		// Token: 0x17001B76 RID: 7030
		// (get) Token: 0x06005B58 RID: 23384 RVA: 0x001A85F4 File Offset: 0x001A67F4
		// (set) Token: 0x06005B59 RID: 23385 RVA: 0x0002B069 File Offset: 0x00029269
		public unsafe bool CanBeAccepted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_CanBeAccepted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_CanBeAccepted)) = value;
			}
		}

		// Token: 0x17001B77 RID: 7031
		// (get) Token: 0x06005B5A RID: 23386 RVA: 0x001A861C File Offset: 0x001A681C
		// (set) Token: 0x06005B5B RID: 23387 RVA: 0x0002B084 File Offset: 0x00029284
		public unsafe bool CanBeRejected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_CanBeRejected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_CanBeRejected)) = value;
			}
		}

		// Token: 0x17001B78 RID: 7032
		// (get) Token: 0x06005B5C RID: 23388 RVA: 0x001A8644 File Offset: 0x001A6844
		// (set) Token: 0x06005B5D RID: 23389 RVA: 0x0002B09F File Offset: 0x0002929F
		public unsafe List<DealGenerationEvent.DayContainer> ApplicableDays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ApplicableDays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DealGenerationEvent.DayContainer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ApplicableDays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B79 RID: 7033
		// (get) Token: 0x06005B5E RID: 23390 RVA: 0x001A8674 File Offset: 0x001A6874
		// (set) Token: 0x06005B5F RID: 23391 RVA: 0x0002B0BE File Offset: 0x000292BE
		public unsafe int GenerationTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_GenerationTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_GenerationTime)) = value;
			}
		}

		// Token: 0x17001B7A RID: 7034
		// (get) Token: 0x06005B60 RID: 23392 RVA: 0x001A869C File Offset: 0x001A689C
		// (set) Token: 0x06005B61 RID: 23393 RVA: 0x0002B0D9 File Offset: 0x000292D9
		public unsafe int GenerationWindowDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_GenerationWindowDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_GenerationWindowDuration)) = value;
			}
		}

		// Token: 0x17001B7B RID: 7035
		// (get) Token: 0x06005B62 RID: 23394 RVA: 0x001A86C4 File Offset: 0x001A68C4
		// (set) Token: 0x06005B63 RID: 23395 RVA: 0x0002B0F4 File Offset: 0x000292F4
		public unsafe ProductList ProductList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ProductList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ProductList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B7C RID: 7036
		// (get) Token: 0x06005B64 RID: 23396 RVA: 0x001A86F4 File Offset: 0x001A68F4
		// (set) Token: 0x06005B65 RID: 23397 RVA: 0x0002B113 File Offset: 0x00029313
		public unsafe float Payment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_Payment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_Payment)) = value;
			}
		}

		// Token: 0x17001B7D RID: 7037
		// (get) Token: 0x06005B66 RID: 23398 RVA: 0x001A871C File Offset: 0x001A691C
		// (set) Token: 0x06005B67 RID: 23399 RVA: 0x0002B12E File Offset: 0x0002932E
		public unsafe float RelationshipRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_RelationshipRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_RelationshipRequirement)) = value;
			}
		}

		// Token: 0x17001B7E RID: 7038
		// (get) Token: 0x06005B68 RID: 23400 RVA: 0x001A8744 File Offset: 0x001A6944
		// (set) Token: 0x06005B69 RID: 23401 RVA: 0x0002B149 File Offset: 0x00029349
		public unsafe Il2CppReferenceArray<MessageChain> RequestMessageChains
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_RequestMessageChains);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MessageChain>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_RequestMessageChains), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B7F RID: 7039
		// (get) Token: 0x06005B6A RID: 23402 RVA: 0x001A8774 File Offset: 0x001A6974
		// (set) Token: 0x06005B6B RID: 23403 RVA: 0x0002B168 File Offset: 0x00029368
		public unsafe Il2CppReferenceArray<MessageChain> ContractAcceptedResponses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ContractAcceptedResponses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MessageChain>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ContractAcceptedResponses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B80 RID: 7040
		// (get) Token: 0x06005B6C RID: 23404 RVA: 0x001A87A4 File Offset: 0x001A69A4
		// (set) Token: 0x06005B6D RID: 23405 RVA: 0x0002B187 File Offset: 0x00029387
		public unsafe Il2CppReferenceArray<MessageChain> ContractRejectedResponses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ContractRejectedResponses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MessageChain>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ContractRejectedResponses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B81 RID: 7041
		// (get) Token: 0x06005B6E RID: 23406 RVA: 0x001A87D4 File Offset: 0x001A69D4
		// (set) Token: 0x06005B6F RID: 23407 RVA: 0x0002B1A6 File Offset: 0x000293A6
		public unsafe DeliveryLocation DeliveryLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_DeliveryLocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryLocation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_DeliveryLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B82 RID: 7042
		// (get) Token: 0x06005B70 RID: 23408 RVA: 0x001A8804 File Offset: 0x001A6A04
		// (set) Token: 0x06005B71 RID: 23409 RVA: 0x0002B1C5 File Offset: 0x000293C5
		public unsafe int PickupScheduleGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_PickupScheduleGroup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_PickupScheduleGroup)) = value;
			}
		}

		// Token: 0x17001B83 RID: 7043
		// (get) Token: 0x06005B72 RID: 23410 RVA: 0x001A882C File Offset: 0x001A6A2C
		// (set) Token: 0x06005B73 RID: 23411 RVA: 0x0002B1E0 File Offset: 0x000293E0
		public unsafe QuestWindowConfig DeliveryWindow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_DeliveryWindow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestWindowConfig>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_DeliveryWindow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B84 RID: 7044
		// (get) Token: 0x06005B74 RID: 23412 RVA: 0x001A885C File Offset: 0x001A6A5C
		// (set) Token: 0x06005B75 RID: 23413 RVA: 0x0002B1FF File Offset: 0x000293FF
		public unsafe bool Expires
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_Expires);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_Expires)) = value;
			}
		}

		// Token: 0x17001B85 RID: 7045
		// (get) Token: 0x06005B76 RID: 23414 RVA: 0x001A8884 File Offset: 0x001A6A84
		// (set) Token: 0x06005B77 RID: 23415 RVA: 0x0002B21A File Offset: 0x0002941A
		public unsafe int ExpiresAfter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ExpiresAfter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.NativeFieldInfoPtr_ExpiresAfter)) = value;
			}
		}

		// Token: 0x04003E6C RID: 15980
		private static readonly IntPtr NativeFieldInfoPtr_Enabled;

		// Token: 0x04003E6D RID: 15981
		private static readonly IntPtr NativeFieldInfoPtr_CanBeAccepted;

		// Token: 0x04003E6E RID: 15982
		private static readonly IntPtr NativeFieldInfoPtr_CanBeRejected;

		// Token: 0x04003E6F RID: 15983
		private static readonly IntPtr NativeFieldInfoPtr_ApplicableDays;

		// Token: 0x04003E70 RID: 15984
		private static readonly IntPtr NativeFieldInfoPtr_GenerationTime;

		// Token: 0x04003E71 RID: 15985
		private static readonly IntPtr NativeFieldInfoPtr_GenerationWindowDuration;

		// Token: 0x04003E72 RID: 15986
		private static readonly IntPtr NativeFieldInfoPtr_ProductList;

		// Token: 0x04003E73 RID: 15987
		private static readonly IntPtr NativeFieldInfoPtr_Payment;

		// Token: 0x04003E74 RID: 15988
		private static readonly IntPtr NativeFieldInfoPtr_RelationshipRequirement;

		// Token: 0x04003E75 RID: 15989
		private static readonly IntPtr NativeFieldInfoPtr_RequestMessageChains;

		// Token: 0x04003E76 RID: 15990
		private static readonly IntPtr NativeFieldInfoPtr_ContractAcceptedResponses;

		// Token: 0x04003E77 RID: 15991
		private static readonly IntPtr NativeFieldInfoPtr_ContractRejectedResponses;

		// Token: 0x04003E78 RID: 15992
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryLocation;

		// Token: 0x04003E79 RID: 15993
		private static readonly IntPtr NativeFieldInfoPtr_PickupScheduleGroup;

		// Token: 0x04003E7A RID: 15994
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryWindow;

		// Token: 0x04003E7B RID: 15995
		private static readonly IntPtr NativeFieldInfoPtr_Expires;

		// Token: 0x04003E7C RID: 15996
		private static readonly IntPtr NativeFieldInfoPtr_ExpiresAfter;

		// Token: 0x04003E7D RID: 15997
		private static readonly IntPtr NativeMethodInfoPtr_GenerateContractInfo_Public_ContractInfo_Customer_0;

		// Token: 0x04003E7E RID: 15998
		private static readonly IntPtr NativeMethodInfoPtr_ShouldGenerate_Public_Boolean_Customer_0;

		// Token: 0x04003E7F RID: 15999
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomRequestMessage_Public_MessageChain_0;

		// Token: 0x04003E80 RID: 16000
		private static readonly IntPtr NativeMethodInfoPtr_ProcessMessage_Public_MessageChain_MessageChain_0;

		// Token: 0x04003E81 RID: 16001
		private static readonly IntPtr NativeMethodInfoPtr_GetRejectionMessage_Public_MessageChain_0;

		// Token: 0x04003E82 RID: 16002
		private static readonly IntPtr NativeMethodInfoPtr_GetAcceptanceMessage_Public_MessageChain_0;

		// Token: 0x04003E83 RID: 16003
		private static readonly IntPtr NativeMethodInfoPtr_GetProductStringList_Public_String_0;

		// Token: 0x04003E84 RID: 16004
		private static readonly IntPtr NativeMethodInfoPtr_GetQualityString_Public_String_0;

		// Token: 0x04003E85 RID: 16005
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009E9 RID: 2537
		[Serializable]
		public class DayContainer : Object
		{
			// Token: 0x0600CD78 RID: 52600 RVA: 0x00317BD4 File Offset: 0x00315DD4
			// Note: this type is marked as 'beforefieldinit'.
			static DayContainer()
			{
				Il2CppClassPointerStore<DealGenerationEvent.DayContainer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "DayContainer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealGenerationEvent.DayContainer>.NativeClassPtr);
				DealGenerationEvent.DayContainer.NativeFieldInfoPtr_Day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent.DayContainer>.NativeClassPtr, "Day");
				DealGenerationEvent.DayContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent.DayContainer>.NativeClassPtr, 100674966);
			}

			// Token: 0x0600CD79 RID: 52601 RVA: 0x00317C28 File Offset: 0x00315E28
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DayContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealGenerationEvent.DayContainer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.DayContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD7A RID: 52602 RVA: 0x00063ED3 File Offset: 0x000620D3
			public DayContainer(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FF4 RID: 16372
			// (get) Token: 0x0600CD7B RID: 52603 RVA: 0x00317C64 File Offset: 0x00315E64
			// (set) Token: 0x0600CD7C RID: 52604 RVA: 0x00063EDC File Offset: 0x000620DC
			public unsafe EDay Day
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.DayContainer.NativeFieldInfoPtr_Day);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealGenerationEvent.DayContainer.NativeFieldInfoPtr_Day)) = value;
				}
			}

			// Token: 0x04008ACC RID: 35532
			private static readonly IntPtr NativeFieldInfoPtr_Day;

			// Token: 0x04008ACD RID: 35533
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009EA RID: 2538
		[ObfuscatedName("ScheduleOne.Economy.DealGenerationEvent+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600CD7D RID: 52605 RVA: 0x00317C8C File Offset: 0x00315E8C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DealGenerationEvent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealGenerationEvent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealGenerationEvent.__c>.NativeClassPtr);
				DealGenerationEvent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent.__c>.NativeClassPtr, "<>9");
				DealGenerationEvent.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealGenerationEvent.__c>.NativeClassPtr, "<>9__19_0");
				DealGenerationEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent.__c>.NativeClassPtr, 100674968);
				DealGenerationEvent.__c.NativeMethodInfoPtr__ShouldGenerate_b__19_0_Internal_Boolean_DayContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealGenerationEvent.__c>.NativeClassPtr, 100674969);
			}

			// Token: 0x0600CD7E RID: 52606 RVA: 0x00317D08 File Offset: 0x00315F08
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealGenerationEvent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD7F RID: 52607 RVA: 0x00317D44 File Offset: 0x00315F44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193191, XrefRangeEnd = 193196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ShouldGenerate_b__19_0(DealGenerationEvent.DayContainer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealGenerationEvent.__c.NativeMethodInfoPtr__ShouldGenerate_b__19_0_Internal_Boolean_DayContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD80 RID: 52608 RVA: 0x00063EF7 File Offset: 0x000620F7
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FF5 RID: 16373
			// (get) Token: 0x0600CD81 RID: 52609 RVA: 0x00317D94 File Offset: 0x00315F94
			// (set) Token: 0x0600CD82 RID: 52610 RVA: 0x00063F00 File Offset: 0x00062100
			public unsafe static DealGenerationEvent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DealGenerationEvent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DealGenerationEvent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DealGenerationEvent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FF6 RID: 16374
			// (get) Token: 0x0600CD83 RID: 52611 RVA: 0x00317DBC File Offset: 0x00315FBC
			// (set) Token: 0x0600CD84 RID: 52612 RVA: 0x00063F12 File Offset: 0x00062112
			public unsafe static Predicate<DealGenerationEvent.DayContainer> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DealGenerationEvent.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<DealGenerationEvent.DayContainer>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DealGenerationEvent.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008ACE RID: 35534
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008ACF RID: 35535
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x04008AD0 RID: 35536
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AD1 RID: 35537
			private static readonly IntPtr NativeMethodInfoPtr__ShouldGenerate_b__19_0_Internal_Boolean_DayContainer_0;
		}
	}
}
