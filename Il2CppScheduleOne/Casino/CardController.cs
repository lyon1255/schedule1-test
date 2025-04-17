﻿using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x020004A0 RID: 1184
	public class CardController : NetworkBehaviour
	{
		// Token: 0x060066EC RID: 26348 RVA: 0x001CEBF8 File Offset: 0x001CCDF8
		// Note: this type is marked as 'beforefieldinit'.
		static CardController()
		{
			Il2CppClassPointerStore<CardController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "CardController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardController>.NativeClassPtr);
			CardController.NativeFieldInfoPtr_cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, "cards");
			CardController.NativeFieldInfoPtr_cardDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, "cardDictionary");
			CardController.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Casino.CardControllerAssembly-CSharp.dll_Excuted");
			CardController.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardController>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Casino.CardControllerAssembly-CSharp.dll_Excuted");
			CardController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676338);
			CardController.NativeMethodInfoPtr_SendCardValue_Public_Void_String_ECardSuit_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676339);
			CardController.NativeMethodInfoPtr_SetCardValue_Private_Void_String_ECardSuit_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676340);
			CardController.NativeMethodInfoPtr_SendCardFaceUp_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676341);
			CardController.NativeMethodInfoPtr_SetCardFaceUp_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676342);
			CardController.NativeMethodInfoPtr_SendCardGlide_Public_Void_String_Vector3_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676343);
			CardController.NativeMethodInfoPtr_SetCardGlide_Private_Void_String_Vector3_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676344);
			CardController.NativeMethodInfoPtr_GetCard_Private_PlayingCard_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676345);
			CardController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676346);
			CardController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676347);
			CardController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676348);
			CardController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676349);
			CardController.NativeMethodInfoPtr_RpcWriter___Server_SendCardValue_3709737967_Private_Void_String_ECardSuit_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676350);
			CardController.NativeMethodInfoPtr_RpcLogic___SendCardValue_3709737967_Public_Void_String_ECardSuit_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676351);
			CardController.NativeMethodInfoPtr_RpcReader___Server_SendCardValue_3709737967_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676352);
			CardController.NativeMethodInfoPtr_RpcWriter___Observers_SetCardValue_3709737967_Private_Void_String_ECardSuit_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676353);
			CardController.NativeMethodInfoPtr_RpcLogic___SetCardValue_3709737967_Private_Void_String_ECardSuit_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676354);
			CardController.NativeMethodInfoPtr_RpcReader___Observers_SetCardValue_3709737967_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676355);
			CardController.NativeMethodInfoPtr_RpcWriter___Server_SendCardFaceUp_310431262_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676356);
			CardController.NativeMethodInfoPtr_RpcLogic___SendCardFaceUp_310431262_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676357);
			CardController.NativeMethodInfoPtr_RpcReader___Server_SendCardFaceUp_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676358);
			CardController.NativeMethodInfoPtr_RpcWriter___Observers_SetCardFaceUp_310431262_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676359);
			CardController.NativeMethodInfoPtr_RpcLogic___SetCardFaceUp_310431262_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676360);
			CardController.NativeMethodInfoPtr_RpcReader___Observers_SetCardFaceUp_310431262_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676361);
			CardController.NativeMethodInfoPtr_RpcWriter___Server_SendCardGlide_2833372058_Private_Void_String_Vector3_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676362);
			CardController.NativeMethodInfoPtr_RpcLogic___SendCardGlide_2833372058_Public_Void_String_Vector3_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676363);
			CardController.NativeMethodInfoPtr_RpcReader___Server_SendCardGlide_2833372058_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676364);
			CardController.NativeMethodInfoPtr_RpcWriter___Observers_SetCardGlide_2833372058_Private_Void_String_Vector3_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676365);
			CardController.NativeMethodInfoPtr_RpcLogic___SetCardGlide_2833372058_Private_Void_String_Vector3_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676366);
			CardController.NativeMethodInfoPtr_RpcReader___Observers_SetCardGlide_2833372058_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676367);
			CardController.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardController>.NativeClassPtr, 100676368);
		}

		// Token: 0x060066ED RID: 26349 RVA: 0x001CEEE4 File Offset: 0x001CD0E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208273, XrefRangeEnd = 208274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066EE RID: 26350 RVA: 0x001CEF20 File Offset: 0x001CD120
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208298, RefRangeEnd = 208299, XrefRangeStart = 208274, XrefRangeEnd = 208298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendCardValue(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_SendCardValue_Public_Void_String_ECardSuit_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066EF RID: 26351 RVA: 0x001CEF80 File Offset: 0x001CD180
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208323, RefRangeEnd = 208325, XrefRangeStart = 208299, XrefRangeEnd = 208323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCardValue(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_SetCardValue_Private_Void_String_ECardSuit_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066F0 RID: 26352 RVA: 0x001CEFE0 File Offset: 0x001CD1E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208348, RefRangeEnd = 208350, XrefRangeStart = 208325, XrefRangeEnd = 208348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendCardFaceUp(string cardId, bool faceUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceUp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_SendCardFaceUp_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066F1 RID: 26353 RVA: 0x001CF030 File Offset: 0x001CD230
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208373, RefRangeEnd = 208375, XrefRangeStart = 208350, XrefRangeEnd = 208373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCardFaceUp(string cardId, bool faceUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceUp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_SetCardFaceUp_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066F2 RID: 26354 RVA: 0x001CF080 File Offset: 0x001CD280
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208378, RefRangeEnd = 208379, XrefRangeStart = 208375, XrefRangeEnd = 208378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendCardGlide(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glideTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_SendCardGlide_Public_Void_String_Vector3_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066F3 RID: 26355 RVA: 0x001CF0EC File Offset: 0x001CD2EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208379, XrefRangeEnd = 208381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCardGlide(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glideTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_SetCardGlide_Private_Void_String_Vector3_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066F4 RID: 26356 RVA: 0x001CF158 File Offset: 0x001CD358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208381, XrefRangeEnd = 208385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayingCard GetCard(string cardId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_GetCard_Private_PlayingCard_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayingCard>(intPtr3) : null;
		}

		// Token: 0x060066F5 RID: 26357 RVA: 0x001CF1A8 File Offset: 0x001CD3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208385, XrefRangeEnd = 208400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CardController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066F6 RID: 26358 RVA: 0x001CF1E4 File Offset: 0x001CD3E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208400, XrefRangeEnd = 208438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066F7 RID: 26359 RVA: 0x001CF220 File Offset: 0x001CD420
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066F8 RID: 26360 RVA: 0x001CF25C File Offset: 0x001CD45C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066F9 RID: 26361 RVA: 0x001CF298 File Offset: 0x001CD498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208438, XrefRangeEnd = 208450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcWriter___Server_SendCardValue_3709737967_Private_Void_String_ECardSuit_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066FA RID: 26362 RVA: 0x001CF2F8 File Offset: 0x001CD4F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208323, RefRangeEnd = 208325, XrefRangeStart = 208323, XrefRangeEnd = 208325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcLogic___SendCardValue_3709737967_Public_Void_String_ECardSuit_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066FB RID: 26363 RVA: 0x001CF358 File Offset: 0x001CD558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208450, XrefRangeEnd = 208456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendCardValue_3709737967(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcReader___Server_SendCardValue_3709737967_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066FC RID: 26364 RVA: 0x001CF3BC File Offset: 0x001CD5BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208456, XrefRangeEnd = 208468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcWriter___Observers_SetCardValue_3709737967_Private_Void_String_ECardSuit_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066FD RID: 26365 RVA: 0x001CF41C File Offset: 0x001CD61C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 208476, RefRangeEnd = 208479, XrefRangeStart = 208468, XrefRangeEnd = 208476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetCardValue_3709737967(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref suit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcLogic___SetCardValue_3709737967_Private_Void_String_ECardSuit_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066FE RID: 26366 RVA: 0x001CF47C File Offset: 0x001CD67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208479, XrefRangeEnd = 208485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetCardValue_3709737967(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcReader___Observers_SetCardValue_3709737967_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060066FF RID: 26367 RVA: 0x001CF4CC File Offset: 0x001CD6CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208485, XrefRangeEnd = 208505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendCardFaceUp_310431262(string cardId, bool faceUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceUp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcWriter___Server_SendCardFaceUp_310431262_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006700 RID: 26368 RVA: 0x001CF51C File Offset: 0x001CD71C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208373, RefRangeEnd = 208375, XrefRangeStart = 208373, XrefRangeEnd = 208375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendCardFaceUp_310431262(string cardId, bool faceUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceUp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcLogic___SendCardFaceUp_310431262_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006701 RID: 26369 RVA: 0x001CF56C File Offset: 0x001CD76C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208505, XrefRangeEnd = 208509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendCardFaceUp_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcReader___Server_SendCardFaceUp_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006702 RID: 26370 RVA: 0x001CF5D0 File Offset: 0x001CD7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208509, XrefRangeEnd = 208529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetCardFaceUp_310431262(string cardId, bool faceUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceUp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcWriter___Observers_SetCardFaceUp_310431262_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006703 RID: 26371 RVA: 0x001CF620 File Offset: 0x001CD820
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 208537, RefRangeEnd = 208540, XrefRangeStart = 208529, XrefRangeEnd = 208537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetCardFaceUp_310431262(string cardId, bool faceUp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceUp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcLogic___SetCardFaceUp_310431262_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006704 RID: 26372 RVA: 0x001CF670 File Offset: 0x001CD870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208540, XrefRangeEnd = 208544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetCardFaceUp_310431262(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcReader___Observers_SetCardFaceUp_310431262_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006705 RID: 26373 RVA: 0x001CF6C0 File Offset: 0x001CD8C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208570, RefRangeEnd = 208571, XrefRangeStart = 208544, XrefRangeEnd = 208570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glideTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcWriter___Server_SendCardGlide_2833372058_Private_Void_String_Vector3_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006706 RID: 26374 RVA: 0x001CF72C File Offset: 0x001CD92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glideTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcLogic___SendCardGlide_2833372058_Public_Void_String_Vector3_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006707 RID: 26375 RVA: 0x001CF798 File Offset: 0x001CD998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208571, XrefRangeEnd = 208582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendCardGlide_2833372058(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcReader___Server_SendCardGlide_2833372058_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006708 RID: 26376 RVA: 0x001CF7FC File Offset: 0x001CD9FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 208608, RefRangeEnd = 208612, XrefRangeStart = 208582, XrefRangeEnd = 208608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glideTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcWriter___Observers_SetCardGlide_2833372058_Private_Void_String_Vector3_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006709 RID: 26377 RVA: 0x001CF868 File Offset: 0x001CDA68
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 208620, RefRangeEnd = 208625, XrefRangeStart = 208612, XrefRangeEnd = 208620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetCardGlide_2833372058(string cardId, Vector3 position, Quaternion rotation, float glideTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glideTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcLogic___SetCardGlide_2833372058_Private_Void_String_Vector3_Quaternion_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600670A RID: 26378 RVA: 0x001CF8D4 File Offset: 0x001CDAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208625, XrefRangeEnd = 208635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetCardGlide_2833372058(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_RpcReader___Observers_SetCardGlide_2833372058_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600670B RID: 26379 RVA: 0x001CF924 File Offset: 0x001CDB24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208676, RefRangeEnd = 208677, XrefRangeStart = 208635, XrefRangeEnd = 208676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardController.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600670C RID: 26380 RVA: 0x00030A96 File Offset: 0x0002EC96
		public CardController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EFB RID: 7931
		// (get) Token: 0x0600670D RID: 26381 RVA: 0x001CF958 File Offset: 0x001CDB58
		// (set) Token: 0x0600670E RID: 26382 RVA: 0x00030A9F File Offset: 0x0002EC9F
		public unsafe List<PlayingCard> cards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_cards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_cards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EFC RID: 7932
		// (get) Token: 0x0600670F RID: 26383 RVA: 0x001CF988 File Offset: 0x001CDB88
		// (set) Token: 0x06006710 RID: 26384 RVA: 0x00030ABE File Offset: 0x0002ECBE
		public unsafe Dictionary<string, PlayingCard> cardDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_cardDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, PlayingCard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_cardDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EFD RID: 7933
		// (get) Token: 0x06006711 RID: 26385 RVA: 0x001CF9B8 File Offset: 0x001CDBB8
		// (set) Token: 0x06006712 RID: 26386 RVA: 0x00030ADD File Offset: 0x0002ECDD
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001EFE RID: 7934
		// (get) Token: 0x06006713 RID: 26387 RVA: 0x001CF9E0 File Offset: 0x001CDBE0
		// (set) Token: 0x06006714 RID: 26388 RVA: 0x00030AF8 File Offset: 0x0002ECF8
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardController.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400466F RID: 18031
		private static readonly IntPtr NativeFieldInfoPtr_cards;

		// Token: 0x04004670 RID: 18032
		private static readonly IntPtr NativeFieldInfoPtr_cardDictionary;

		// Token: 0x04004671 RID: 18033
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004672 RID: 18034
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004673 RID: 18035
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004674 RID: 18036
		private static readonly IntPtr NativeMethodInfoPtr_SendCardValue_Public_Void_String_ECardSuit_ECardValue_0;

		// Token: 0x04004675 RID: 18037
		private static readonly IntPtr NativeMethodInfoPtr_SetCardValue_Private_Void_String_ECardSuit_ECardValue_0;

		// Token: 0x04004676 RID: 18038
		private static readonly IntPtr NativeMethodInfoPtr_SendCardFaceUp_Public_Void_String_Boolean_0;

		// Token: 0x04004677 RID: 18039
		private static readonly IntPtr NativeMethodInfoPtr_SetCardFaceUp_Private_Void_String_Boolean_0;

		// Token: 0x04004678 RID: 18040
		private static readonly IntPtr NativeMethodInfoPtr_SendCardGlide_Public_Void_String_Vector3_Quaternion_Single_0;

		// Token: 0x04004679 RID: 18041
		private static readonly IntPtr NativeMethodInfoPtr_SetCardGlide_Private_Void_String_Vector3_Quaternion_Single_0;

		// Token: 0x0400467A RID: 18042
		private static readonly IntPtr NativeMethodInfoPtr_GetCard_Private_PlayingCard_String_0;

		// Token: 0x0400467B RID: 18043
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400467C RID: 18044
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400467D RID: 18045
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400467E RID: 18046
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400467F RID: 18047
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendCardValue_3709737967_Private_Void_String_ECardSuit_ECardValue_0;

		// Token: 0x04004680 RID: 18048
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendCardValue_3709737967_Public_Void_String_ECardSuit_ECardValue_0;

		// Token: 0x04004681 RID: 18049
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendCardValue_3709737967_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004682 RID: 18050
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetCardValue_3709737967_Private_Void_String_ECardSuit_ECardValue_0;

		// Token: 0x04004683 RID: 18051
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetCardValue_3709737967_Private_Void_String_ECardSuit_ECardValue_0;

		// Token: 0x04004684 RID: 18052
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetCardValue_3709737967_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004685 RID: 18053
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendCardFaceUp_310431262_Private_Void_String_Boolean_0;

		// Token: 0x04004686 RID: 18054
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendCardFaceUp_310431262_Public_Void_String_Boolean_0;

		// Token: 0x04004687 RID: 18055
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendCardFaceUp_310431262_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004688 RID: 18056
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetCardFaceUp_310431262_Private_Void_String_Boolean_0;

		// Token: 0x04004689 RID: 18057
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetCardFaceUp_310431262_Private_Void_String_Boolean_0;

		// Token: 0x0400468A RID: 18058
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetCardFaceUp_310431262_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400468B RID: 18059
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendCardGlide_2833372058_Private_Void_String_Vector3_Quaternion_Single_0;

		// Token: 0x0400468C RID: 18060
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendCardGlide_2833372058_Public_Void_String_Vector3_Quaternion_Single_0;

		// Token: 0x0400468D RID: 18061
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendCardGlide_2833372058_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400468E RID: 18062
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetCardGlide_2833372058_Private_Void_String_Vector3_Quaternion_Single_0;

		// Token: 0x0400468F RID: 18063
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetCardGlide_2833372058_Private_Void_String_Vector3_Quaternion_Single_0;

		// Token: 0x04004690 RID: 18064
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetCardGlide_2833372058_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004691 RID: 18065
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;
	}
}
