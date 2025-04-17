using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x020004A5 RID: 1189
	public class PlayingCard : MonoBehaviour
	{
		// Token: 0x060067A9 RID: 26537 RVA: 0x001D242C File Offset: 0x001D062C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayingCard()
		{
			Il2CppClassPointerStore<PlayingCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "PlayingCard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr);
			PlayingCard.NativeFieldInfoPtr__IsFaceUp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "<IsFaceUp>k__BackingField");
			PlayingCard.NativeFieldInfoPtr__Suit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "<Suit>k__BackingField");
			PlayingCard.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "<Value>k__BackingField");
			PlayingCard.NativeFieldInfoPtr__CardController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "<CardController>k__BackingField");
			PlayingCard.NativeFieldInfoPtr_CardID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "CardID");
			PlayingCard.NativeFieldInfoPtr_CardSpriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "CardSpriteRenderer");
			PlayingCard.NativeFieldInfoPtr_CardSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "CardSprites");
			PlayingCard.NativeFieldInfoPtr_FlipAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "FlipAnimation");
			PlayingCard.NativeFieldInfoPtr_FlipFaceUpClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "FlipFaceUpClip");
			PlayingCard.NativeFieldInfoPtr_FlipFaceDownClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "FlipFaceDownClip");
			PlayingCard.NativeFieldInfoPtr_FlipSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "FlipSound");
			PlayingCard.NativeFieldInfoPtr_LandSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "LandSound");
			PlayingCard.NativeFieldInfoPtr_moveRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "moveRoutine");
			PlayingCard.NativeFieldInfoPtr_lastGlideTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "lastGlideTarget");
			PlayingCard.NativeMethodInfoPtr_get_IsFaceUp_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676462);
			PlayingCard.NativeMethodInfoPtr_set_IsFaceUp_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676463);
			PlayingCard.NativeMethodInfoPtr_get_Suit_Public_get_ECardSuit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676464);
			PlayingCard.NativeMethodInfoPtr_set_Suit_Private_set_Void_ECardSuit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676465);
			PlayingCard.NativeMethodInfoPtr_get_Value_Public_get_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676466);
			PlayingCard.NativeMethodInfoPtr_set_Value_Private_set_Void_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676467);
			PlayingCard.NativeMethodInfoPtr_get_CardController_Public_get_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676468);
			PlayingCard.NativeMethodInfoPtr_set_CardController_Private_set_Void_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676469);
			PlayingCard.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676470);
			PlayingCard.NativeMethodInfoPtr_SetCardController_Public_Void_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676471);
			PlayingCard.NativeMethodInfoPtr_SetCard_Public_Void_ECardSuit_ECardValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676472);
			PlayingCard.NativeMethodInfoPtr_ClearCard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676473);
			PlayingCard.NativeMethodInfoPtr_SetFaceUp_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676474);
			PlayingCard.NativeMethodInfoPtr_GlideTo_Public_Void_Vector3_Quaternion_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676475);
			PlayingCard.NativeMethodInfoPtr_GetCardSprite_Private_CardSprite_ECardSuit_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676476);
			PlayingCard.NativeMethodInfoPtr_VerifyCardSprites_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676477);
			PlayingCard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, 100676478);
		}

		// Token: 0x17001F2B RID: 7979
		// (get) Token: 0x060067AA RID: 26538 RVA: 0x001D26C8 File Offset: 0x001D08C8
		// (set) Token: 0x060067AB RID: 26539 RVA: 0x001D2704 File Offset: 0x001D0904
		public unsafe bool IsFaceUp
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_get_IsFaceUp_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_set_IsFaceUp_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F2C RID: 7980
		// (get) Token: 0x060067AC RID: 26540 RVA: 0x001D2744 File Offset: 0x001D0944
		// (set) Token: 0x060067AD RID: 26541 RVA: 0x001D2780 File Offset: 0x001D0980
		public unsafe PlayingCard.ECardSuit Suit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_get_Suit_Public_get_ECardSuit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29962, RefRangeEnd = 29963, XrefRangeStart = 29962, XrefRangeEnd = 29963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_set_Suit_Private_set_Void_ECardSuit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F2D RID: 7981
		// (get) Token: 0x060067AE RID: 26542 RVA: 0x001D27C0 File Offset: 0x001D09C0
		// (set) Token: 0x060067AF RID: 26543 RVA: 0x001D27FC File Offset: 0x001D09FC
		public unsafe PlayingCard.ECardValue Value
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29987, RefRangeEnd = 29988, XrefRangeStart = 29987, XrefRangeEnd = 29988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_get_Value_Public_get_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29988, RefRangeEnd = 29989, XrefRangeStart = 29988, XrefRangeEnd = 29989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_set_Value_Private_set_Void_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F2E RID: 7982
		// (get) Token: 0x060067B0 RID: 26544 RVA: 0x001D283C File Offset: 0x001D0A3C
		// (set) Token: 0x060067B1 RID: 26545 RVA: 0x001D287C File Offset: 0x001D0A7C
		public unsafe CardController CardController
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_get_CardController_Public_get_CardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CardController>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19661, RefRangeEnd = 19662, XrefRangeStart = 19661, XrefRangeEnd = 19662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_set_CardController_Private_set_Void_CardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060067B2 RID: 26546 RVA: 0x001D28C0 File Offset: 0x001D0AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210108, XrefRangeEnd = 210116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067B3 RID: 26547 RVA: 0x001D28F4 File Offset: 0x001D0AF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19661, RefRangeEnd = 19662, XrefRangeStart = 19661, XrefRangeEnd = 19662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCardController(CardController cardController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_SetCardController_Public_Void_CardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067B4 RID: 26548 RVA: 0x001D2938 File Offset: 0x001D0B38
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 210121, RefRangeEnd = 210125, XrefRangeStart = 210116, XrefRangeEnd = 210121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCard(PlayingCard.ECardSuit suit, PlayingCard.ECardValue value, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref suit;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_SetCard_Public_Void_ECardSuit_ECardValue_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067B5 RID: 26549 RVA: 0x001D2994 File Offset: 0x001D0B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210125, XrefRangeEnd = 210126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_ClearCard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067B6 RID: 26550 RVA: 0x001D29C8 File Offset: 0x001D0BC8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 210134, RefRangeEnd = 210142, XrefRangeStart = 210126, XrefRangeEnd = 210134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFaceUp(bool faceUp, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref faceUp;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_SetFaceUp_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067B7 RID: 26551 RVA: 0x001D2A14 File Offset: 0x001D0C14
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 210156, RefRangeEnd = 210166, XrefRangeStart = 210142, XrefRangeEnd = 210156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GlideTo(Vector3 position, Quaternion rotation, float duration = 0.5f, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_GlideTo_Public_Void_Vector3_Quaternion_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067B8 RID: 26552 RVA: 0x001D2A7C File Offset: 0x001D0C7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210180, RefRangeEnd = 210181, XrefRangeStart = 210166, XrefRangeEnd = 210180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayingCard.CardSprite GetCardSprite(PlayingCard.ECardSuit suit, PlayingCard.ECardValue val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref suit;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_GetCardSprite_Private_CardSprite_ECardSuit_ECardValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayingCard.CardSprite>(intPtr3) : null;
		}

		// Token: 0x060067B9 RID: 26553 RVA: 0x001D2AD8 File Offset: 0x001D0CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210181, XrefRangeEnd = 210261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VerifyCardSprites()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr_VerifyCardSprites_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067BA RID: 26554 RVA: 0x001D2B0C File Offset: 0x001D0D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210261, XrefRangeEnd = 210266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayingCard() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060067BB RID: 26555 RVA: 0x00030E04 File Offset: 0x0002F004
		public PlayingCard(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F1D RID: 7965
		// (get) Token: 0x060067BC RID: 26556 RVA: 0x001D2B48 File Offset: 0x001D0D48
		// (set) Token: 0x060067BD RID: 26557 RVA: 0x00030E0D File Offset: 0x0002F00D
		public unsafe bool _IsFaceUp_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__IsFaceUp_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__IsFaceUp_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F1E RID: 7966
		// (get) Token: 0x060067BE RID: 26558 RVA: 0x001D2B70 File Offset: 0x001D0D70
		// (set) Token: 0x060067BF RID: 26559 RVA: 0x00030E28 File Offset: 0x0002F028
		public unsafe PlayingCard.ECardSuit _Suit_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__Suit_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__Suit_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F1F RID: 7967
		// (get) Token: 0x060067C0 RID: 26560 RVA: 0x001D2B98 File Offset: 0x001D0D98
		// (set) Token: 0x060067C1 RID: 26561 RVA: 0x00030E43 File Offset: 0x0002F043
		public unsafe PlayingCard.ECardValue _Value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__Value_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__Value_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F20 RID: 7968
		// (get) Token: 0x060067C2 RID: 26562 RVA: 0x001D2BC0 File Offset: 0x001D0DC0
		// (set) Token: 0x060067C3 RID: 26563 RVA: 0x00030E5E File Offset: 0x0002F05E
		public unsafe CardController _CardController_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__CardController_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr__CardController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F21 RID: 7969
		// (get) Token: 0x060067C4 RID: 26564 RVA: 0x001D2BF0 File Offset: 0x001D0DF0
		// (set) Token: 0x060067C5 RID: 26565 RVA: 0x00030E7D File Offset: 0x0002F07D
		public unsafe string CardID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_CardID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_CardID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001F22 RID: 7970
		// (get) Token: 0x060067C6 RID: 26566 RVA: 0x001D2C18 File Offset: 0x001D0E18
		// (set) Token: 0x060067C7 RID: 26567 RVA: 0x00030E9C File Offset: 0x0002F09C
		public unsafe SpriteRenderer CardSpriteRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_CardSpriteRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_CardSpriteRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F23 RID: 7971
		// (get) Token: 0x060067C8 RID: 26568 RVA: 0x001D2C48 File Offset: 0x001D0E48
		// (set) Token: 0x060067C9 RID: 26569 RVA: 0x00030EBB File Offset: 0x0002F0BB
		public unsafe Il2CppReferenceArray<PlayingCard.CardSprite> CardSprites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_CardSprites);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayingCard.CardSprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_CardSprites), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F24 RID: 7972
		// (get) Token: 0x060067CA RID: 26570 RVA: 0x001D2C78 File Offset: 0x001D0E78
		// (set) Token: 0x060067CB RID: 26571 RVA: 0x00030EDA File Offset: 0x0002F0DA
		public unsafe Animation FlipAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F25 RID: 7973
		// (get) Token: 0x060067CC RID: 26572 RVA: 0x001D2CA8 File Offset: 0x001D0EA8
		// (set) Token: 0x060067CD RID: 26573 RVA: 0x00030EF9 File Offset: 0x0002F0F9
		public unsafe AnimationClip FlipFaceUpClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipFaceUpClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipFaceUpClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F26 RID: 7974
		// (get) Token: 0x060067CE RID: 26574 RVA: 0x001D2CD8 File Offset: 0x001D0ED8
		// (set) Token: 0x060067CF RID: 26575 RVA: 0x00030F18 File Offset: 0x0002F118
		public unsafe AnimationClip FlipFaceDownClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipFaceDownClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipFaceDownClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F27 RID: 7975
		// (get) Token: 0x060067D0 RID: 26576 RVA: 0x001D2D08 File Offset: 0x001D0F08
		// (set) Token: 0x060067D1 RID: 26577 RVA: 0x00030F37 File Offset: 0x0002F137
		public unsafe AudioSourceController FlipSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_FlipSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F28 RID: 7976
		// (get) Token: 0x060067D2 RID: 26578 RVA: 0x001D2D38 File Offset: 0x001D0F38
		// (set) Token: 0x060067D3 RID: 26579 RVA: 0x00030F56 File Offset: 0x0002F156
		public unsafe AudioSourceController LandSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_LandSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_LandSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F29 RID: 7977
		// (get) Token: 0x060067D4 RID: 26580 RVA: 0x001D2D68 File Offset: 0x001D0F68
		// (set) Token: 0x060067D5 RID: 26581 RVA: 0x00030F75 File Offset: 0x0002F175
		public unsafe Coroutine moveRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_moveRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_moveRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F2A RID: 7978
		// (get) Token: 0x060067D6 RID: 26582 RVA: 0x001D2D98 File Offset: 0x001D0F98
		// (set) Token: 0x060067D7 RID: 26583 RVA: 0x00030F94 File Offset: 0x0002F194
		public unsafe Tuple<Vector3, Quaternion> lastGlideTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_lastGlideTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tuple<Vector3, Quaternion>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.NativeFieldInfoPtr_lastGlideTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004705 RID: 18181
		private static readonly IntPtr NativeFieldInfoPtr__IsFaceUp_k__BackingField;

		// Token: 0x04004706 RID: 18182
		private static readonly IntPtr NativeFieldInfoPtr__Suit_k__BackingField;

		// Token: 0x04004707 RID: 18183
		private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

		// Token: 0x04004708 RID: 18184
		private static readonly IntPtr NativeFieldInfoPtr__CardController_k__BackingField;

		// Token: 0x04004709 RID: 18185
		private static readonly IntPtr NativeFieldInfoPtr_CardID;

		// Token: 0x0400470A RID: 18186
		private static readonly IntPtr NativeFieldInfoPtr_CardSpriteRenderer;

		// Token: 0x0400470B RID: 18187
		private static readonly IntPtr NativeFieldInfoPtr_CardSprites;

		// Token: 0x0400470C RID: 18188
		private static readonly IntPtr NativeFieldInfoPtr_FlipAnimation;

		// Token: 0x0400470D RID: 18189
		private static readonly IntPtr NativeFieldInfoPtr_FlipFaceUpClip;

		// Token: 0x0400470E RID: 18190
		private static readonly IntPtr NativeFieldInfoPtr_FlipFaceDownClip;

		// Token: 0x0400470F RID: 18191
		private static readonly IntPtr NativeFieldInfoPtr_FlipSound;

		// Token: 0x04004710 RID: 18192
		private static readonly IntPtr NativeFieldInfoPtr_LandSound;

		// Token: 0x04004711 RID: 18193
		private static readonly IntPtr NativeFieldInfoPtr_moveRoutine;

		// Token: 0x04004712 RID: 18194
		private static readonly IntPtr NativeFieldInfoPtr_lastGlideTarget;

		// Token: 0x04004713 RID: 18195
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFaceUp_Public_get_Boolean_0;

		// Token: 0x04004714 RID: 18196
		private static readonly IntPtr NativeMethodInfoPtr_set_IsFaceUp_Private_set_Void_Boolean_0;

		// Token: 0x04004715 RID: 18197
		private static readonly IntPtr NativeMethodInfoPtr_get_Suit_Public_get_ECardSuit_0;

		// Token: 0x04004716 RID: 18198
		private static readonly IntPtr NativeMethodInfoPtr_set_Suit_Private_set_Void_ECardSuit_0;

		// Token: 0x04004717 RID: 18199
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_ECardValue_0;

		// Token: 0x04004718 RID: 18200
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Private_set_Void_ECardValue_0;

		// Token: 0x04004719 RID: 18201
		private static readonly IntPtr NativeMethodInfoPtr_get_CardController_Public_get_CardController_0;

		// Token: 0x0400471A RID: 18202
		private static readonly IntPtr NativeMethodInfoPtr_set_CardController_Private_set_Void_CardController_0;

		// Token: 0x0400471B RID: 18203
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x0400471C RID: 18204
		private static readonly IntPtr NativeMethodInfoPtr_SetCardController_Public_Void_CardController_0;

		// Token: 0x0400471D RID: 18205
		private static readonly IntPtr NativeMethodInfoPtr_SetCard_Public_Void_ECardSuit_ECardValue_Boolean_0;

		// Token: 0x0400471E RID: 18206
		private static readonly IntPtr NativeMethodInfoPtr_ClearCard_Public_Void_0;

		// Token: 0x0400471F RID: 18207
		private static readonly IntPtr NativeMethodInfoPtr_SetFaceUp_Public_Void_Boolean_Boolean_0;

		// Token: 0x04004720 RID: 18208
		private static readonly IntPtr NativeMethodInfoPtr_GlideTo_Public_Void_Vector3_Quaternion_Single_Boolean_0;

		// Token: 0x04004721 RID: 18209
		private static readonly IntPtr NativeMethodInfoPtr_GetCardSprite_Private_CardSprite_ECardSuit_ECardValue_0;

		// Token: 0x04004722 RID: 18210
		private static readonly IntPtr NativeMethodInfoPtr_VerifyCardSprites_Public_Void_0;

		// Token: 0x04004723 RID: 18211
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A42 RID: 2626
		[Serializable]
		public class CardSprite : Il2CppSystem.Object
		{
			// Token: 0x0600CFDF RID: 53215 RVA: 0x0031E600 File Offset: 0x0031C800
			// Note: this type is marked as 'beforefieldinit'.
			static CardSprite()
			{
				Il2CppClassPointerStore<PlayingCard.CardSprite>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "CardSprite");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayingCard.CardSprite>.NativeClassPtr);
				PlayingCard.CardSprite.NativeFieldInfoPtr_Suit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.CardSprite>.NativeClassPtr, "Suit");
				PlayingCard.CardSprite.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.CardSprite>.NativeClassPtr, "Value");
				PlayingCard.CardSprite.NativeFieldInfoPtr_Sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.CardSprite>.NativeClassPtr, "Sprite");
				PlayingCard.CardSprite.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.CardSprite>.NativeClassPtr, 100676479);
			}

			// Token: 0x0600CFE0 RID: 53216 RVA: 0x0031E67C File Offset: 0x0031C87C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CardSprite() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayingCard.CardSprite>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.CardSprite.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFE1 RID: 53217 RVA: 0x00065224 File Offset: 0x00063424
			public CardSprite(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004092 RID: 16530
			// (get) Token: 0x0600CFE2 RID: 53218 RVA: 0x0031E6B8 File Offset: 0x0031C8B8
			// (set) Token: 0x0600CFE3 RID: 53219 RVA: 0x0006522D File Offset: 0x0006342D
			public unsafe PlayingCard.ECardSuit Suit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.CardSprite.NativeFieldInfoPtr_Suit);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.CardSprite.NativeFieldInfoPtr_Suit)) = value;
				}
			}

			// Token: 0x17004093 RID: 16531
			// (get) Token: 0x0600CFE4 RID: 53220 RVA: 0x0031E6E0 File Offset: 0x0031C8E0
			// (set) Token: 0x0600CFE5 RID: 53221 RVA: 0x00065248 File Offset: 0x00063448
			public unsafe PlayingCard.ECardValue Value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.CardSprite.NativeFieldInfoPtr_Value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.CardSprite.NativeFieldInfoPtr_Value)) = value;
				}
			}

			// Token: 0x17004094 RID: 16532
			// (get) Token: 0x0600CFE6 RID: 53222 RVA: 0x0031E708 File Offset: 0x0031C908
			// (set) Token: 0x0600CFE7 RID: 53223 RVA: 0x00065263 File Offset: 0x00063463
			public unsafe Sprite Sprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.CardSprite.NativeFieldInfoPtr_Sprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.CardSprite.NativeFieldInfoPtr_Sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C2E RID: 35886
			private static readonly IntPtr NativeFieldInfoPtr_Suit;

			// Token: 0x04008C2F RID: 35887
			private static readonly IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x04008C30 RID: 35888
			private static readonly IntPtr NativeFieldInfoPtr_Sprite;

			// Token: 0x04008C31 RID: 35889
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A43 RID: 2627
		[StructLayout(2)]
		public struct CardData
		{
			// Token: 0x0600CFE8 RID: 53224 RVA: 0x0031E738 File Offset: 0x0031C938
			// Note: this type is marked as 'beforefieldinit'.
			static CardData()
			{
				Il2CppClassPointerStore<PlayingCard.CardData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "CardData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayingCard.CardData>.NativeClassPtr);
				PlayingCard.CardData.NativeFieldInfoPtr_Suit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.CardData>.NativeClassPtr, "Suit");
				PlayingCard.CardData.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.CardData>.NativeClassPtr, "Value");
				PlayingCard.CardData.NativeMethodInfoPtr__ctor_Public_Void_ECardSuit_ECardValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.CardData>.NativeClassPtr, 100676480);
			}

			// Token: 0x0600CFE9 RID: 53225 RVA: 0x0031E7A0 File Offset: 0x0031C9A0
			[CallerCount(93)]
			[CachedScanResults(RefRangeStart = 34314, RefRangeEnd = 34407, XrefRangeStart = 34314, XrefRangeEnd = 34407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CardData(PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref suit;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.CardData.NativeMethodInfoPtr__ctor_Public_Void_ECardSuit_ECardValue_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFEA RID: 53226 RVA: 0x00065282 File Offset: 0x00063482
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayingCard.CardData>.NativeClassPtr, ref this));
			}

			// Token: 0x04008C32 RID: 35890
			private static readonly IntPtr NativeFieldInfoPtr_Suit;

			// Token: 0x04008C33 RID: 35891
			private static readonly IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x04008C34 RID: 35892
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ECardSuit_ECardValue_0;

			// Token: 0x04008C35 RID: 35893
			[FieldOffset(0)]
			public PlayingCard.ECardSuit Suit;

			// Token: 0x04008C36 RID: 35894
			[FieldOffset(4)]
			public PlayingCard.ECardValue Value;
		}

		// Token: 0x02000A44 RID: 2628
		[OriginalName("Assembly-CSharp.dll", "", "ECardSuit")]
		public enum ECardSuit
		{
			// Token: 0x04008C38 RID: 35896
			Spades,
			// Token: 0x04008C39 RID: 35897
			Hearts,
			// Token: 0x04008C3A RID: 35898
			Diamonds,
			// Token: 0x04008C3B RID: 35899
			Clubs
		}

		// Token: 0x02000A45 RID: 2629
		[OriginalName("Assembly-CSharp.dll", "", "ECardValue")]
		public enum ECardValue
		{
			// Token: 0x04008C3D RID: 35901
			Blank,
			// Token: 0x04008C3E RID: 35902
			Ace,
			// Token: 0x04008C3F RID: 35903
			Two,
			// Token: 0x04008C40 RID: 35904
			Three,
			// Token: 0x04008C41 RID: 35905
			Four,
			// Token: 0x04008C42 RID: 35906
			Five,
			// Token: 0x04008C43 RID: 35907
			Six,
			// Token: 0x04008C44 RID: 35908
			Seven,
			// Token: 0x04008C45 RID: 35909
			Eight,
			// Token: 0x04008C46 RID: 35910
			Nine,
			// Token: 0x04008C47 RID: 35911
			Ten,
			// Token: 0x04008C48 RID: 35912
			Jack,
			// Token: 0x04008C49 RID: 35913
			Queen,
			// Token: 0x04008C4A RID: 35914
			King
		}

		// Token: 0x02000A46 RID: 2630
		[ObfuscatedName("ScheduleOne.Casino.PlayingCard+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CFEB RID: 53227 RVA: 0x0031E7E0 File Offset: 0x0031C9E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr);
				PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, "<>4__this");
				PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, "duration");
				PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, "position");
				PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_verticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, "verticalOffset");
				PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, "rotation");
				PlayingCard.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, 100676481);
				PlayingCard.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, 100676482);
			}

			// Token: 0x0600CFEC RID: 53228 RVA: 0x0031E898 File Offset: 0x0031CA98
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFED RID: 53229 RVA: 0x0031E8D4 File Offset: 0x0031CAD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210103, XrefRangeEnd = 210108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CFEE RID: 53230 RVA: 0x00065294 File Offset: 0x00063494
			public __c__DisplayClass35_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004095 RID: 16533
			// (get) Token: 0x0600CFEF RID: 53231 RVA: 0x0031E914 File Offset: 0x0031CB14
			// (set) Token: 0x0600CFF0 RID: 53232 RVA: 0x0006529D File Offset: 0x0006349D
			public unsafe PlayingCard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayingCard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004096 RID: 16534
			// (get) Token: 0x0600CFF1 RID: 53233 RVA: 0x0031E944 File Offset: 0x0031CB44
			// (set) Token: 0x0600CFF2 RID: 53234 RVA: 0x000652BC File Offset: 0x000634BC
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x17004097 RID: 16535
			// (get) Token: 0x0600CFF3 RID: 53235 RVA: 0x0031E96C File Offset: 0x0031CB6C
			// (set) Token: 0x0600CFF4 RID: 53236 RVA: 0x000652D7 File Offset: 0x000634D7
			public unsafe Vector3 position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_position);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_position)) = value;
				}
			}

			// Token: 0x17004098 RID: 16536
			// (get) Token: 0x0600CFF5 RID: 53237 RVA: 0x0031E994 File Offset: 0x0031CB94
			// (set) Token: 0x0600CFF6 RID: 53238 RVA: 0x000652F2 File Offset: 0x000634F2
			public unsafe float verticalOffset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_verticalOffset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_verticalOffset)) = value;
				}
			}

			// Token: 0x17004099 RID: 16537
			// (get) Token: 0x0600CFF7 RID: 53239 RVA: 0x0031E9BC File Offset: 0x0031CBBC
			// (set) Token: 0x0600CFF8 RID: 53240 RVA: 0x0006530D File Offset: 0x0006350D
			public unsafe Quaternion rotation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_rotation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.NativeFieldInfoPtr_rotation)) = value;
				}
			}

			// Token: 0x04008C4B RID: 35915
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C4C RID: 35916
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x04008C4D RID: 35917
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x04008C4E RID: 35918
			private static readonly IntPtr NativeFieldInfoPtr_verticalOffset;

			// Token: 0x04008C4F RID: 35919
			private static readonly IntPtr NativeFieldInfoPtr_rotation;

			// Token: 0x04008C50 RID: 35920
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C51 RID: 35921
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C59 RID: 3161
			[ObfuscatedName("ScheduleOne.Casino.PlayingCard+<>c__DisplayClass35_0+<<GlideTo>g__MoveRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E398 RID: 58264 RVA: 0x0035684C File Offset: 0x00354A4C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique()
				{
					Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0>.NativeClassPtr, "<<GlideTo>g__MoveRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr);
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, "<>1__state");
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, "<>2__current");
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, "<>4__this");
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__startPosition_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, "<startPosition>5__2");
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__startRotation_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, "<startRotation>5__3");
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__time_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, "<time>5__4");
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, 100676483);
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, 100676484);
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, 100676485);
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, 100676486);
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, 100676487);
					PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr, 100676488);
				}

				// Token: 0x0600E399 RID: 58265 RVA: 0x00356968 File Offset: 0x00354B68
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E39A RID: 58266 RVA: 0x003569B0 File Offset: 0x00354BB0
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E39B RID: 58267 RVA: 0x003569E4 File Offset: 0x00354BE4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210078, XrefRangeEnd = 210098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170046A7 RID: 18087
				// (get) Token: 0x0600E39C RID: 58268 RVA: 0x00356A20 File Offset: 0x00354C20
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E39D RID: 58269 RVA: 0x00356A60 File Offset: 0x00354C60
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210098, XrefRangeEnd = 210103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170046A8 RID: 18088
				// (get) Token: 0x0600E39E RID: 58270 RVA: 0x00356A94 File Offset: 0x00354C94
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E39F RID: 58271 RVA: 0x0006EEF3 File Offset: 0x0006D0F3
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170046A1 RID: 18081
				// (get) Token: 0x0600E3A0 RID: 58272 RVA: 0x00356AD4 File Offset: 0x00354CD4
				// (set) Token: 0x0600E3A1 RID: 58273 RVA: 0x0006EEFC File Offset: 0x0006D0FC
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170046A2 RID: 18082
				// (get) Token: 0x0600E3A2 RID: 58274 RVA: 0x00356AFC File Offset: 0x00354CFC
				// (set) Token: 0x0600E3A3 RID: 58275 RVA: 0x0006EF17 File Offset: 0x0006D117
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046A3 RID: 18083
				// (get) Token: 0x0600E3A4 RID: 58276 RVA: 0x00356B2C File Offset: 0x00354D2C
				// (set) Token: 0x0600E3A5 RID: 58277 RVA: 0x0006EF36 File Offset: 0x0006D136
				public unsafe PlayingCard.__c__DisplayClass35_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayingCard.__c__DisplayClass35_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046A4 RID: 18084
				// (get) Token: 0x0600E3A6 RID: 58278 RVA: 0x00356B5C File Offset: 0x00354D5C
				// (set) Token: 0x0600E3A7 RID: 58279 RVA: 0x0006EF55 File Offset: 0x0006D155
				public unsafe Vector3 _startPosition_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__startPosition_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__startPosition_5__2)) = value;
					}
				}

				// Token: 0x170046A5 RID: 18085
				// (get) Token: 0x0600E3A8 RID: 58280 RVA: 0x00356B84 File Offset: 0x00354D84
				// (set) Token: 0x0600E3A9 RID: 58281 RVA: 0x0006EF70 File Offset: 0x0006D170
				public unsafe Quaternion _startRotation_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__startRotation_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__startRotation_5__3)) = value;
					}
				}

				// Token: 0x170046A6 RID: 18086
				// (get) Token: 0x0600E3AA RID: 58282 RVA: 0x00356BAC File Offset: 0x00354DAC
				// (set) Token: 0x0600E3AB RID: 58283 RVA: 0x0006EF8B File Offset: 0x0006D18B
				public unsafe float _time_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__time_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeQuSiObObUnique.NativeFieldInfoPtr__time_5__4)) = value;
					}
				}

				// Token: 0x0400984A RID: 38986
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400984B RID: 38987
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400984C RID: 38988
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400984D RID: 38989
				private static readonly IntPtr NativeFieldInfoPtr__startPosition_5__2;

				// Token: 0x0400984E RID: 38990
				private static readonly IntPtr NativeFieldInfoPtr__startRotation_5__3;

				// Token: 0x0400984F RID: 38991
				private static readonly IntPtr NativeFieldInfoPtr__time_5__4;

				// Token: 0x04009850 RID: 38992
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009851 RID: 38993
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009852 RID: 38994
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009853 RID: 38995
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009854 RID: 38996
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009855 RID: 38997
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000A47 RID: 2631
		[ObfuscatedName("ScheduleOne.Casino.PlayingCard+<>c__DisplayClass36_0")]
		public sealed class __c__DisplayClass36_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CFF9 RID: 53241 RVA: 0x0031E9E4 File Offset: 0x0031CBE4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<PlayingCard.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayingCard>.NativeClassPtr, "<>c__DisplayClass36_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass36_0>.NativeClassPtr);
				PlayingCard.__c__DisplayClass36_0.NativeFieldInfoPtr_suit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass36_0>.NativeClassPtr, "suit");
				PlayingCard.__c__DisplayClass36_0.NativeFieldInfoPtr_val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass36_0>.NativeClassPtr, "val");
				PlayingCard.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass36_0>.NativeClassPtr, 100676489);
				PlayingCard.__c__DisplayClass36_0.NativeMethodInfoPtr__GetCardSprite_b__0_Internal_Boolean_CardSprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass36_0>.NativeClassPtr, 100676490);
			}

			// Token: 0x0600CFFA RID: 53242 RVA: 0x0031EA60 File Offset: 0x0031CC60
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayingCard.__c__DisplayClass36_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CFFB RID: 53243 RVA: 0x0031EA9C File Offset: 0x0031CC9C
			[CallerCount(0)]
			public unsafe bool _GetCardSprite_b__0(PlayingCard.CardSprite x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayingCard.__c__DisplayClass36_0.NativeMethodInfoPtr__GetCardSprite_b__0_Internal_Boolean_CardSprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CFFC RID: 53244 RVA: 0x00065328 File Offset: 0x00063528
			public __c__DisplayClass36_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700409A RID: 16538
			// (get) Token: 0x0600CFFD RID: 53245 RVA: 0x0031EAEC File Offset: 0x0031CCEC
			// (set) Token: 0x0600CFFE RID: 53246 RVA: 0x00065331 File Offset: 0x00063531
			public unsafe PlayingCard.ECardSuit suit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass36_0.NativeFieldInfoPtr_suit);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass36_0.NativeFieldInfoPtr_suit)) = value;
				}
			}

			// Token: 0x1700409B RID: 16539
			// (get) Token: 0x0600CFFF RID: 53247 RVA: 0x0031EB14 File Offset: 0x0031CD14
			// (set) Token: 0x0600D000 RID: 53248 RVA: 0x0006534C File Offset: 0x0006354C
			public unsafe PlayingCard.ECardValue val
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass36_0.NativeFieldInfoPtr_val);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayingCard.__c__DisplayClass36_0.NativeFieldInfoPtr_val)) = value;
				}
			}

			// Token: 0x04008C52 RID: 35922
			private static readonly IntPtr NativeFieldInfoPtr_suit;

			// Token: 0x04008C53 RID: 35923
			private static readonly IntPtr NativeFieldInfoPtr_val;

			// Token: 0x04008C54 RID: 35924
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C55 RID: 35925
			private static readonly IntPtr NativeMethodInfoPtr__GetCardSprite_b__0_Internal_Boolean_CardSprite_0;
		}
	}
}
