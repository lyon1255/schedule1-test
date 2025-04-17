using System;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000333 RID: 819
	public class SchizoGoblin : NPC
	{
		// Token: 0x06003C63 RID: 15459 RVA: 0x00134BDC File Offset: 0x00132DDC
		// Note: this type is marked as 'beforefieldinit'.
		static SchizoGoblin()
		{
			Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "SchizoGoblin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr);
			SchizoGoblin.NativeFieldInfoPtr_targetPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr, "targetPlayer");
			SchizoGoblin.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.SchizoGoblinAssembly-CSharp.dll_Excuted");
			SchizoGoblin.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.SchizoGoblinAssembly-CSharp.dll_Excuted");
			SchizoGoblin.NativeMethodInfoPtr_SetTargetPlayer_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr, 100670337);
			SchizoGoblin.NativeMethodInfoPtr_Activate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr, 100670338);
			SchizoGoblin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr, 100670339);
			SchizoGoblin.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr, 100670340);
			SchizoGoblin.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr, 100670341);
			SchizoGoblin.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr, 100670342);
			SchizoGoblin.NativeMethodInfoPtr_RpcWriter___Observers_SetTargetPlayer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr, 100670343);
			SchizoGoblin.NativeMethodInfoPtr_RpcLogic___SetTargetPlayer_3323014238_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr, 100670344);
			SchizoGoblin.NativeMethodInfoPtr_RpcReader___Observers_SetTargetPlayer_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr, 100670345);
			SchizoGoblin.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr, 100670346);
		}

		// Token: 0x06003C64 RID: 15460 RVA: 0x00134D10 File Offset: 0x00132F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142853, XrefRangeEnd = 142872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetPlayer(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchizoGoblin.NativeMethodInfoPtr_SetTargetPlayer_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C65 RID: 15461 RVA: 0x00134D54 File Offset: 0x00132F54
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchizoGoblin.NativeMethodInfoPtr_Activate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C66 RID: 15462 RVA: 0x00134D88 File Offset: 0x00132F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchizoGoblin() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchizoGoblin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchizoGoblin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C67 RID: 15463 RVA: 0x00134DC4 File Offset: 0x00132FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142872, XrefRangeEnd = 142880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchizoGoblin.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C68 RID: 15464 RVA: 0x00134E00 File Offset: 0x00133000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchizoGoblin.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C69 RID: 15465 RVA: 0x00134E3C File Offset: 0x0013303C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchizoGoblin.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C6A RID: 15466 RVA: 0x00134E78 File Offset: 0x00133078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetTargetPlayer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchizoGoblin.NativeMethodInfoPtr_RpcWriter___Observers_SetTargetPlayer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C6B RID: 15467 RVA: 0x00134EBC File Offset: 0x001330BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142880, XrefRangeEnd = 142895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetTargetPlayer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchizoGoblin.NativeMethodInfoPtr_RpcLogic___SetTargetPlayer_3323014238_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C6C RID: 15468 RVA: 0x00134F00 File Offset: 0x00133100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142895, XrefRangeEnd = 142911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetTargetPlayer_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchizoGoblin.NativeMethodInfoPtr_RpcReader___Observers_SetTargetPlayer_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C6D RID: 15469 RVA: 0x00134F50 File Offset: 0x00133150
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 141969, RefRangeEnd = 141972, XrefRangeStart = 141969, XrefRangeEnd = 141972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchizoGoblin.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C6E RID: 15470 RVA: 0x0001EA11 File Offset: 0x0001CC11
		public SchizoGoblin(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x06003C6F RID: 15471 RVA: 0x00134F8C File Offset: 0x0013318C
		// (set) Token: 0x06003C70 RID: 15472 RVA: 0x0001EA1A File Offset: 0x0001CC1A
		public unsafe Player targetPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchizoGoblin.NativeFieldInfoPtr_targetPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchizoGoblin.NativeFieldInfoPtr_targetPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012CF RID: 4815
		// (get) Token: 0x06003C71 RID: 15473 RVA: 0x00134FBC File Offset: 0x001331BC
		// (set) Token: 0x06003C72 RID: 15474 RVA: 0x0001EA39 File Offset: 0x0001CC39
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchizoGoblin.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchizoGoblin.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170012D0 RID: 4816
		// (get) Token: 0x06003C73 RID: 15475 RVA: 0x00134FE4 File Offset: 0x001331E4
		// (set) Token: 0x06003C74 RID: 15476 RVA: 0x0001EA54 File Offset: 0x0001CC54
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchizoGoblin.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchizoGoblin.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040027D3 RID: 10195
		private static readonly IntPtr NativeFieldInfoPtr_targetPlayer;

		// Token: 0x040027D4 RID: 10196
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040027D5 RID: 10197
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040027D6 RID: 10198
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetPlayer_Public_Void_NetworkObject_0;

		// Token: 0x040027D7 RID: 10199
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Void_0;

		// Token: 0x040027D8 RID: 10200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040027D9 RID: 10201
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040027DA RID: 10202
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040027DB RID: 10203
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040027DC RID: 10204
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetTargetPlayer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040027DD RID: 10205
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetTargetPlayer_3323014238_Public_Void_NetworkObject_0;

		// Token: 0x040027DE RID: 10206
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetTargetPlayer_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x040027DF RID: 10207
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
