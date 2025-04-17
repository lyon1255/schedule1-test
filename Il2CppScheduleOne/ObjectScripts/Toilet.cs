using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Interaction;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200072C RID: 1836
	public class Toilet : GridItem
	{
		// Token: 0x0600A688 RID: 42632 RVA: 0x0029A590 File Offset: 0x00298790
		// Note: this type is marked as 'beforefieldinit'.
		static Toilet()
		{
			Il2CppClassPointerStore<Toilet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Toilet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Toilet>.NativeClassPtr);
			Toilet.NativeFieldInfoPtr_InitialDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "InitialDelay");
			Toilet.NativeFieldInfoPtr_FlushTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "FlushTime");
			Toilet.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "IntObj");
			Toilet.NativeFieldInfoPtr_ItemLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "ItemLayerMask");
			Toilet.NativeFieldInfoPtr_ItemDetectionCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "ItemDetectionCollider");
			Toilet.NativeFieldInfoPtr_OnFlush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "OnFlush");
			Toilet.NativeFieldInfoPtr__flushCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "_flushCoroutine");
			Toilet.NativeFieldInfoPtr_isFlushing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "isFlushing");
			Toilet.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.ToiletAssembly-CSharp.dll_Excuted");
			Toilet.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.ToiletAssembly-CSharp.dll_Excuted");
			Toilet.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683679);
			Toilet.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683680);
			Toilet.NativeMethodInfoPtr_SendFlush_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683681);
			Toilet.NativeMethodInfoPtr_Flush_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683682);
			Toilet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683683);
			Toilet.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683684);
			Toilet.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683685);
			Toilet.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683686);
			Toilet.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683687);
			Toilet.NativeMethodInfoPtr_RpcWriter___Server_SendFlush_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683688);
			Toilet.NativeMethodInfoPtr_RpcLogic___SendFlush_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683689);
			Toilet.NativeMethodInfoPtr_RpcReader___Server_SendFlush_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683690);
			Toilet.NativeMethodInfoPtr_RpcWriter___Observers_Flush_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683691);
			Toilet.NativeMethodInfoPtr_RpcLogic___Flush_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683692);
			Toilet.NativeMethodInfoPtr_RpcReader___Observers_Flush_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683693);
			Toilet.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet>.NativeClassPtr, 100683694);
		}

		// Token: 0x0600A689 RID: 42633 RVA: 0x0029A7C8 File Offset: 0x002989C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290516, XrefRangeEnd = 290517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A68A RID: 42634 RVA: 0x0029A7FC File Offset: 0x002989FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290517, XrefRangeEnd = 290535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A68B RID: 42635 RVA: 0x0029A830 File Offset: 0x00298A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290535, XrefRangeEnd = 290553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendFlush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_SendFlush_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A68C RID: 42636 RVA: 0x0029A864 File Offset: 0x00298A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290553, XrefRangeEnd = 290571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_Flush_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A68D RID: 42637 RVA: 0x0029A898 File Offset: 0x00298A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290571, XrefRangeEnd = 290572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Toilet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Toilet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A68E RID: 42638 RVA: 0x0029A8D4 File Offset: 0x00298AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290572, XrefRangeEnd = 290577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A68F RID: 42639 RVA: 0x0029A914 File Offset: 0x00298B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290577, XrefRangeEnd = 290592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toilet.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A690 RID: 42640 RVA: 0x0029A950 File Offset: 0x00298B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290592, XrefRangeEnd = 290593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toilet.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A691 RID: 42641 RVA: 0x0029A98C File Offset: 0x00298B8C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toilet.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A692 RID: 42642 RVA: 0x0029A9C8 File Offset: 0x00298BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendFlush_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_RpcWriter___Server_SendFlush_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A693 RID: 42643 RVA: 0x0029A9FC File Offset: 0x00298BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendFlush_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_RpcLogic___SendFlush_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A694 RID: 42644 RVA: 0x0029AA30 File Offset: 0x00298C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290593, XrefRangeEnd = 290603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendFlush_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_RpcReader___Server_SendFlush_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A695 RID: 42645 RVA: 0x0029AA94 File Offset: 0x00298C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Flush_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_RpcWriter___Observers_Flush_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A696 RID: 42646 RVA: 0x0029AAC8 File Offset: 0x00298CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290603, XrefRangeEnd = 290610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Flush_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_RpcLogic___Flush_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A697 RID: 42647 RVA: 0x0029AAFC File Offset: 0x00298CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290610, XrefRangeEnd = 290618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Flush_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.NativeMethodInfoPtr_RpcReader___Observers_Flush_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A698 RID: 42648 RVA: 0x0029AB4C File Offset: 0x00298D4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290619, RefRangeEnd = 290620, XrefRangeStart = 290618, XrefRangeEnd = 290619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Toilet.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A699 RID: 42649 RVA: 0x000520AA File Offset: 0x000502AA
		public Toilet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003362 RID: 13154
		// (get) Token: 0x0600A69A RID: 42650 RVA: 0x0029AB88 File Offset: 0x00298D88
		// (set) Token: 0x0600A69B RID: 42651 RVA: 0x000520B3 File Offset: 0x000502B3
		public unsafe float InitialDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_InitialDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_InitialDelay)) = value;
			}
		}

		// Token: 0x17003363 RID: 13155
		// (get) Token: 0x0600A69C RID: 42652 RVA: 0x0029ABB0 File Offset: 0x00298DB0
		// (set) Token: 0x0600A69D RID: 42653 RVA: 0x000520CE File Offset: 0x000502CE
		public unsafe float FlushTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_FlushTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_FlushTime)) = value;
			}
		}

		// Token: 0x17003364 RID: 13156
		// (get) Token: 0x0600A69E RID: 42654 RVA: 0x0029ABD8 File Offset: 0x00298DD8
		// (set) Token: 0x0600A69F RID: 42655 RVA: 0x000520E9 File Offset: 0x000502E9
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003365 RID: 13157
		// (get) Token: 0x0600A6A0 RID: 42656 RVA: 0x0029AC08 File Offset: 0x00298E08
		// (set) Token: 0x0600A6A1 RID: 42657 RVA: 0x00052108 File Offset: 0x00050308
		public unsafe LayerMask ItemLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_ItemLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_ItemLayerMask)) = value;
			}
		}

		// Token: 0x17003366 RID: 13158
		// (get) Token: 0x0600A6A2 RID: 42658 RVA: 0x0029AC30 File Offset: 0x00298E30
		// (set) Token: 0x0600A6A3 RID: 42659 RVA: 0x00052123 File Offset: 0x00050323
		public unsafe SphereCollider ItemDetectionCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_ItemDetectionCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SphereCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_ItemDetectionCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003367 RID: 13159
		// (get) Token: 0x0600A6A4 RID: 42660 RVA: 0x0029AC60 File Offset: 0x00298E60
		// (set) Token: 0x0600A6A5 RID: 42661 RVA: 0x00052142 File Offset: 0x00050342
		public unsafe UnityEvent OnFlush
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_OnFlush);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_OnFlush), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003368 RID: 13160
		// (get) Token: 0x0600A6A6 RID: 42662 RVA: 0x0029AC90 File Offset: 0x00298E90
		// (set) Token: 0x0600A6A7 RID: 42663 RVA: 0x00052161 File Offset: 0x00050361
		public unsafe Coroutine _flushCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr__flushCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr__flushCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003369 RID: 13161
		// (get) Token: 0x0600A6A8 RID: 42664 RVA: 0x0029ACC0 File Offset: 0x00298EC0
		// (set) Token: 0x0600A6A9 RID: 42665 RVA: 0x00052180 File Offset: 0x00050380
		public unsafe bool isFlushing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_isFlushing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_isFlushing)) = value;
			}
		}

		// Token: 0x1700336A RID: 13162
		// (get) Token: 0x0600A6AA RID: 42666 RVA: 0x0029ACE8 File Offset: 0x00298EE8
		// (set) Token: 0x0600A6AB RID: 42667 RVA: 0x0005219B File Offset: 0x0005039B
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700336B RID: 13163
		// (get) Token: 0x0600A6AC RID: 42668 RVA: 0x0029AD10 File Offset: 0x00298F10
		// (set) Token: 0x0600A6AD RID: 42669 RVA: 0x000521B6 File Offset: 0x000503B6
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006FB2 RID: 28594
		private static readonly IntPtr NativeFieldInfoPtr_InitialDelay;

		// Token: 0x04006FB3 RID: 28595
		private static readonly IntPtr NativeFieldInfoPtr_FlushTime;

		// Token: 0x04006FB4 RID: 28596
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04006FB5 RID: 28597
		private static readonly IntPtr NativeFieldInfoPtr_ItemLayerMask;

		// Token: 0x04006FB6 RID: 28598
		private static readonly IntPtr NativeFieldInfoPtr_ItemDetectionCollider;

		// Token: 0x04006FB7 RID: 28599
		private static readonly IntPtr NativeFieldInfoPtr_OnFlush;

		// Token: 0x04006FB8 RID: 28600
		private static readonly IntPtr NativeFieldInfoPtr__flushCoroutine;

		// Token: 0x04006FB9 RID: 28601
		private static readonly IntPtr NativeFieldInfoPtr_isFlushing;

		// Token: 0x04006FBA RID: 28602
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006FBB RID: 28603
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006FBC RID: 28604
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04006FBD RID: 28605
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04006FBE RID: 28606
		private static readonly IntPtr NativeMethodInfoPtr_SendFlush_Private_Void_0;

		// Token: 0x04006FBF RID: 28607
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Private_Void_0;

		// Token: 0x04006FC0 RID: 28608
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006FC1 RID: 28609
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04006FC2 RID: 28610
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006FC3 RID: 28611
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006FC4 RID: 28612
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006FC5 RID: 28613
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendFlush_2166136261_Private_Void_0;

		// Token: 0x04006FC6 RID: 28614
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendFlush_2166136261_Private_Void_0;

		// Token: 0x04006FC7 RID: 28615
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendFlush_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006FC8 RID: 28616
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Flush_2166136261_Private_Void_0;

		// Token: 0x04006FC9 RID: 28617
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Flush_2166136261_Private_Void_0;

		// Token: 0x04006FCA RID: 28618
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Flush_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006FCB RID: 28619
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000BD3 RID: 3027
		[ObfuscatedName("ScheduleOne.ObjectScripts.Toilet+<<Flush>g__Routine|11_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DE7F RID: 56959 RVA: 0x00347AEC File Offset: 0x00345CEC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique()
			{
				Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Toilet>.NativeClassPtr, "<<Flush>g__Routine|11_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr);
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, "<>1__state");
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, "<>2__current");
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, "<>4__this");
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__checkRate_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, "<checkRate>5__2");
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__reps_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, "<reps>5__3");
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, "<i>5__4");
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, 100683695);
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, 100683696);
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, 100683697);
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, 100683698);
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, 100683699);
				Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr, 100683700);
			}

			// Token: 0x0600DE80 RID: 56960 RVA: 0x00347C08 File Offset: 0x00345E08
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE81 RID: 56961 RVA: 0x00347C50 File Offset: 0x00345E50
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE82 RID: 56962 RVA: 0x00347C84 File Offset: 0x00345E84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290460, XrefRangeEnd = 290511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004500 RID: 17664
			// (get) Token: 0x0600DE83 RID: 56963 RVA: 0x00347CC0 File Offset: 0x00345EC0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE84 RID: 56964 RVA: 0x00347D00 File Offset: 0x00345F00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290511, XrefRangeEnd = 290516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004501 RID: 17665
			// (get) Token: 0x0600DE85 RID: 56965 RVA: 0x00347D34 File Offset: 0x00345F34
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE86 RID: 56966 RVA: 0x0006C7B4 File Offset: 0x0006A9B4
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044FA RID: 17658
			// (get) Token: 0x0600DE87 RID: 56967 RVA: 0x00347D74 File Offset: 0x00345F74
			// (set) Token: 0x0600DE88 RID: 56968 RVA: 0x0006C7BD File Offset: 0x0006A9BD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044FB RID: 17659
			// (get) Token: 0x0600DE89 RID: 56969 RVA: 0x00347D9C File Offset: 0x00345F9C
			// (set) Token: 0x0600DE8A RID: 56970 RVA: 0x0006C7D8 File Offset: 0x0006A9D8
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044FC RID: 17660
			// (get) Token: 0x0600DE8B RID: 56971 RVA: 0x00347DCC File Offset: 0x00345FCC
			// (set) Token: 0x0600DE8C RID: 56972 RVA: 0x0006C7F7 File Offset: 0x0006A9F7
			public unsafe Toilet __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toilet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044FD RID: 17661
			// (get) Token: 0x0600DE8D RID: 56973 RVA: 0x00347DFC File Offset: 0x00345FFC
			// (set) Token: 0x0600DE8E RID: 56974 RVA: 0x0006C816 File Offset: 0x0006AA16
			public unsafe float _checkRate_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__checkRate_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__checkRate_5__2)) = value;
				}
			}

			// Token: 0x170044FE RID: 17662
			// (get) Token: 0x0600DE8F RID: 56975 RVA: 0x00347E24 File Offset: 0x00346024
			// (set) Token: 0x0600DE90 RID: 56976 RVA: 0x0006C831 File Offset: 0x0006AA31
			public unsafe int _reps_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__reps_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__reps_5__3)) = value;
				}
			}

			// Token: 0x170044FF RID: 17663
			// (get) Token: 0x0600DE91 RID: 56977 RVA: 0x00347E4C File Offset: 0x0034604C
			// (set) Token: 0x0600DE92 RID: 56978 RVA: 0x0006C84C File Offset: 0x0006AA4C
			public unsafe int _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Toilet.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObToSiInObInObUnique.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x040094F8 RID: 38136
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040094F9 RID: 38137
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040094FA RID: 38138
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040094FB RID: 38139
			private static readonly IntPtr NativeFieldInfoPtr__checkRate_5__2;

			// Token: 0x040094FC RID: 38140
			private static readonly IntPtr NativeFieldInfoPtr__reps_5__3;

			// Token: 0x040094FD RID: 38141
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x040094FE RID: 38142
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040094FF RID: 38143
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009500 RID: 38144
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009501 RID: 38145
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009502 RID: 38146
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009503 RID: 38147
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
